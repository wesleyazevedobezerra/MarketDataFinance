using MarketDataFinance.Application.Interfaces;
using PuppeteerSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.Services
{
    public class ScreenshotAppService : IScreenshotAppService
    {

        private readonly ISummaryAppService _summaryAppService;

        public ScreenshotAppService(ISummaryAppService summaryAppService)
        {
            _summaryAppService = summaryAppService;
        }


        public async Task<string> GetScreenshotBase64Async()
        {
           string GetPercentClass(double percent) => percent >= 0 ? "positivo" : "negativo";
            string GetPlusMinusClass(double percent) => percent >= 0 ? "+" : "-";

            var ibovespa = await _summaryAppService.SearchMarketSummary("^BVSP");
           var usdBRL = await _summaryAppService.SearchMarketSummary("USDBRL%3DX");
           var sep500 = await _summaryAppService.SearchMarketSummary("^GSPC");
           var eurBRL = await _summaryAppService.SearchMarketSummary("EURBRL%3DX");


            double ibovespaPercent = ibovespa?.Data?[0]?.quote?.RegularMarketChangePercent ?? 0;
            double usdPercent = usdBRL?.Data?[0]?.quote?.RegularMarketChangePercent ?? 0;
            double sep500Percent = sep500?.Data?[0]?.quote?.RegularMarketChangePercent ?? 0;
            double eurPercent = eurBRL?.Data?[0]?.quote?.RegularMarketChangePercent ?? 0;



            string ibovClass = GetPercentClass(Math.Truncate(ibovespaPercent));
            string usdClass = GetPercentClass(Math.Truncate(usdPercent));
            string spClass = GetPercentClass(Math.Truncate(sep500Percent));
            string eurClass = GetPercentClass(Math.Truncate(eurPercent));

            string ibovPlusMinus = GetPlusMinusClass(Math.Truncate(ibovespaPercent));
            string usdPlusMinus = GetPlusMinusClass(Math.Truncate(usdPercent));
            string spPlusMinus = GetPlusMinusClass(Math.Truncate(sep500Percent));
            string eurPlusMinus = GetPlusMinusClass(Math.Truncate(eurPercent));


            string IbovespaRegularMarketChangePercent = Math.Truncate(ibovespaPercent).ToString("N2").Replace(",", ".");
            string usdPercentRegularMarketChangePercent = Math.Truncate(usdPercent).ToString("N2").Replace(",", ".");
            string sep500RegularMarketChangePercent = Math.Truncate(sep500Percent).ToString("N2").Replace(",", ".");

            string eurRegularMarketChangePercent = Math.Truncate(eurPercent).ToString("N2").Replace(",", ".");



            string IbovespaRegularMarketPrice = Math.Truncate(ibovespa?.Data?[0]?.quote?.RegularMarketPrice ?? 0).ToString("N0").Replace(",", ".");
            string usdBRLRegularMarketPrice = Math.Truncate(usdBRL?.Data?[0]?.quote?.RegularMarketPrice ?? 0).ToString("N0").Replace(",", ".");
            string sep500RegularMarketPrice = Math.Truncate(sep500?.Data?[0]?.quote?.RegularMarketPrice ?? 0).ToString("N0").Replace(",", ".");
            string eurBRLRegularMarketPrice = Math.Truncate(eurBRL?.Data?[0]?.quote?.RegularMarketPrice ?? 0).ToString("N0").Replace(",", ".");

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
                                <body>"+
                                  @$"<div class='container'>
                                    <div class='header'>
                                      <h1>fechamento<br>de mercado</h1>
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
                                        <span>R$ {usdBRLRegularMarketPrice}</span>
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
                                        <span>R$ {eurBRLRegularMarketPrice}</span>
                                        <span class='{eurClass}'>{eurPlusMinus}{eurRegularMarketChangePercent}%</span>
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
