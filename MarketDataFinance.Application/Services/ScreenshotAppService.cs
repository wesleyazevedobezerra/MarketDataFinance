using MarketDataFinance.Application.Interfaces;
using MarketDataFinance.Application.ViewModels;
using PuppeteerSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.Services
{
    public class ScreenshotAppService : IScreenshotAppService
    {

        private readonly IFinanceChartAppService _financeChartAppService;

        public ScreenshotAppService(IFinanceChartAppService financeChartAppService)
        {
            _financeChartAppService = financeChartAppService;
        }



        public async Task<string> GetScreenshotBase64Async()
        {
            string GetPercentClass(double percent) => percent >= 0 ? "positivo" : "negativo";
            string GetPlusMinusClass(double percent) => percent >= 0 ? "+" : "-";

            var ibovespa = await _financeChartAppService.SearchChartFinance("^BVSP");
            var usdBRL = await _financeChartAppService.SearchChartFinance("USDBRL%3DX");
            var sep500 = await _financeChartAppService.SearchChartFinance("^GSPC");
            var eurBRL = await _financeChartAppService.SearchChartFinance("EURBRL%3DX");
            var nasdaq = await _financeChartAppService.SearchChartFinance("^IXIC");

            MetaFinanceChartViewModel metaIbovesp = ibovespa.Chart.Result[0].Meta;
            MetaFinanceChartViewModel metaUsd = usdBRL.Chart.Result[0].Meta;
            MetaFinanceChartViewModel metasep500 = sep500.Chart.Result[0].Meta;
            MetaFinanceChartViewModel metaEur = eurBRL.Chart.Result[0].Meta;
            MetaFinanceChartViewModel metaNasdaq = nasdaq.Chart.Result[0].Meta;


            double ibovespaPercent = ((metaIbovesp.RegularMarketPrice - metaIbovesp.ChartPreviousClose) / metaIbovesp.ChartPreviousClose) * 100;
            double usdPercent = ((metaUsd.RegularMarketPrice - metaUsd.ChartPreviousClose) / metaUsd.ChartPreviousClose) * 100;
            double sep500Percent = ((metasep500.RegularMarketPrice - metasep500.ChartPreviousClose) / metasep500.ChartPreviousClose) * 100;
            double eurPercent = ((metaEur.RegularMarketPrice - metaEur.ChartPreviousClose) / metaEur.ChartPreviousClose) * 100;
            double nasdaqPercent = ((metaNasdaq.RegularMarketPrice - metaNasdaq.ChartPreviousClose) / metaNasdaq.ChartPreviousClose) * 100;


            string ibovClass = GetPercentClass((ibovespaPercent));
            string usdClass = GetPercentClass((usdPercent));
            string spClass = GetPercentClass((sep500Percent));
            string eurClass = GetPercentClass((eurPercent));
            string nasdaqClass = GetPercentClass((nasdaqPercent));

            string ibovPlusMinus = GetPlusMinusClass((ibovespaPercent));
            string usdPlusMinus = GetPlusMinusClass((usdPercent));
            string spPlusMinus = GetPlusMinusClass((sep500Percent));
            string eurPlusMinus = GetPlusMinusClass((eurPercent));
            string nasdaqPlusMinus = GetPlusMinusClass((nasdaqPercent));


            string IbovespaRegularMarketChangePercent = ((ibovespaPercent < 0) ? (ibovespaPercent * -1) : ibovespaPercent).ToString("N2").Replace(",", ".");
            string usdPercentRegularMarketChangePercent = ((usdPercent < 0) ? (usdPercent * -1) : usdPercent).ToString("N2").Replace(",", ".");
            string sep500RegularMarketChangePercent = ((sep500Percent < 0) ? (sep500Percent * -1) : sep500Percent).ToString("N2").Replace(",", ".");
            string eurRegularMarketChangePercent = ((eurPercent < 0) ? (eurPercent * -1) : eurPercent).ToString("N2").Replace(",", ".");
            string nasdaqRegularMarketChangePercent = ((nasdaqPercent < 0) ? (nasdaqPercent * -1) : nasdaqPercent).ToString("N2").Replace(",", ".");


            string IbovespaRegularMarketPrice = Math.Truncate(ibovespa.Chart?.Result?[0]?.Meta?.RegularMarketPrice ?? 0).ToString("N0").Replace(",", ".");
            string usdBRLRegularMarketPrice = (usdBRL.Chart?.Result?[0]?.Meta?.RegularMarketPrice ?? 0).ToString("N2").Replace(",", ".");
            string sep500RegularMarketPrice = Math.Truncate(sep500.Chart?.Result?[0]?.Meta?.RegularMarketPrice ?? 0).ToString("N0").Replace(",", ".");
            string eurBRLRegularMarketPrice = (eurBRL.Chart?.Result?[0]?.Meta?.RegularMarketPrice ?? 0).ToString("N2").Replace(",", ".");
            string nasdaqBRLRegularMarketPrice = (nasdaq.Chart?.Result?[0]?.Meta?.RegularMarketPrice ?? 0).ToString("N2").Replace(",", ".");

            var html = @"
                                <!DOCTYPE html>
                                <html lang='pt-BR'>
                                <head>
                                  <meta charset='UTF-8'>
                                  <title>Fechamento de Mercado</title>
                                  <style>
                                    body {
                                      margin: 0;
                                      padding: 0;
                                      background-color: #24425A;
                                      font-family: Arial, sans-serif;
                                      color: white;
                                      display: flex;
                                      justify-content: center;
                                      align-items: flex-start;
                                      height: 100vh;
                                    }
                                    .container {
                                      width: 400px;
                                      padding: 40px 20px;
                                      position: relative;
                                    }
                                    .logo {
                                      position: absolute;
                                      top: 40px;
                                      right: 20px;
                                    }
                                    .logo img {
                                      height: 60px;
                                      width: auto;
                                    }
                                    .header {
                                      margin-bottom: 40px;
                                    }
                                    .header h1 {
                                      font-size: 24px;
                                      margin: 0;
                                      font-weight: normal;
                                      line-height: 1.2;
                                    }
                                    .header p {
                                      margin: 5px 0 0;
                                      font-size: 14px;
                                      color: #d9d9d9;
                                    }
                                    .linha {
                                      display: flex;
                                      justify-content: space-between;
                                      border-top: 1px solid #4d6b85;
                                      padding: 16px 0;
                                    }
                                    .linha:first-of-type {
                                      border-top: none;
                                    }
                                    .esquerda {
                                      font-weight: bold;
                                      text-transform: lowercase;
                                    }
                                    .direita {
                                      text-align: right;
                                    }
                                    .direita span {
                                      display: block;
                                    }
                                    .positivo {
                                      color: #8cf2b0;
                                    }
                                    .negativo {
                                      color: #ff9999;
                                    }
                                  </style>
                                </head>
                                <body>" +
                                  @$"<div class='container'>
                                    <div class='header'>
                                      <h1>Fechamento<br>de Mercado</h1>
                                      <p>{DateTime.Now.ToString("dd/MM/yyyy")}</p>
                                    </div>
                                    <div class='linha'>
                                      <div class='esquerda'>ibovespa</div>
                                      <div class='direita'>
                                        <span>{IbovespaRegularMarketPrice} pts</span>
                                        <span class='{ibovClass}'>{ibovPlusMinus}{IbovespaRegularMarketChangePercent}%</span>
                                      </div>
                                    </div>
                                    <div class='linha'>
                                      <div class='esquerda'>dólar</div>
                                      <div class='direita'>
                                        <span> {usdBRLRegularMarketPrice}</span>
                                        <span class='{usdClass}'>{usdPlusMinus}{usdPercentRegularMarketChangePercent}%</span>
                                      </div>
                                    </div>
                                    <div class='linha'>
                                      <div class='esquerda'>s&amp;p 500</div>
                                      <div class='direita'>
                                        <span>{sep500RegularMarketPrice} pts</span>
                                        <span class='{spClass}'>{spPlusMinus}{sep500RegularMarketChangePercent}%</span>
                                      </div>
                                    </div>
                                    <div class='linha'>
                                      <div class='esquerda'>euro</div>
                                      <div class='direita'>
                                        <span> {eurBRLRegularMarketPrice}</span>
                                        <span class='{eurClass}'>{eurPlusMinus}{eurRegularMarketChangePercent}%</span>
                                      </div>
                                    </div>
                                    <div class='linha'>
                                      <div class='esquerda'>nasdaq</div>
                                      <div class='direita'>
                                        <span> {nasdaqBRLRegularMarketPrice}</span>
                                        <span class='{nasdaqClass}'>{nasdaqPlusMinus}{nasdaqRegularMarketChangePercent}%</span>
                                      </div>
                                    </div>
                                  </div>
                                </body>
                                </html>";

            // Baixa o Chromium se não existir
            await new BrowserFetcher().DownloadAsync();

            // Lança navegador headless
            using var browser = await Puppeteer.LaunchAsync(new LaunchOptions { Headless = true });
            using var page = await browser.NewPageAsync();

            // Define o conteúdo HTML
            await page.SetContentAsync(html);

            // Define o tamanho da viewport para corresponder ao conteúdo
            await page.SetViewportAsync(new ViewPortOptions { Width = 480, Height = 600 });

            // Tira screenshot e salva arquivo PNG
            var screenshotBytes = await page.ScreenshotDataAsync(new ScreenshotOptions { FullPage = false });

            // Converte para Base64
            string base64String = Convert.ToBase64String(screenshotBytes);

            return base64String;
        }
    }
}
