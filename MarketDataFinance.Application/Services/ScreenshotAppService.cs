using MarketDataFinance.Application.Factories;
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
            

            var ibovespa = await _financeChartAppService.SearchChartFinance("^BVSP");
            var usdBRL = await _financeChartAppService.SearchChartFinance("USDBRL%3DX");
            var sep500 = await _financeChartAppService.SearchChartFinance("^GSPC");
            var eurBRL = await _financeChartAppService.SearchChartFinance("EURBRL%3DX");
            var nasdaq = await _financeChartAppService.SearchChartFinance("^IXIC");


            var entityIbovespa = ScreenshotFactory.SetEntityToViewModel(ibovespa);
            var entityUsdBrl = ScreenshotFactory.SetEntityToViewModel(usdBRL);
            var entitySep500 = ScreenshotFactory.SetEntityToViewModel(sep500);
            var entityEurBrl = ScreenshotFactory.SetEntityToViewModel(eurBRL);
            var entityNasdaq = ScreenshotFactory.SetEntityToViewModel(nasdaq);



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
                                        <span>{entityIbovespa.RegularMarketPrice} pts</span>
                                        <span class='{entityIbovespa.PercentClass}'>{entityIbovespa.PercentPlusMinusClass}{entityIbovespa.PercentString}%</span>
                                      </div>
                                    </div>
                                    <div class='linha'>
                                      <div class='esquerda'>dólar</div>
                                      <div class='direita'>
                                        <span> {entityUsdBrl.RegularMarketPrice}</span>
                                        <span class='{entityUsdBrl.PercentClass}'>{entityUsdBrl.PercentPlusMinusClass}{entityUsdBrl.PercentString}%</span>
                                      </div>
                                    </div>
                                    <div class='linha'>
                                      <div class='esquerda'>s&amp;p 500</div>
                                      <div class='direita'>
                                        <span>{entitySep500.RegularMarketPrice} pts</span>
                                        <span class='{entitySep500.PercentClass}'>{entitySep500.PercentPlusMinusClass}{entitySep500.PercentString}%</span>
                                      </div>
                                    </div>
                                    <div class='linha'>
                                      <div class='esquerda'>euro</div>
                                      <div class='direita'>
                                        <span> {entityEurBrl.RegularMarketPrice}</span>
                                        <span class='{entityEurBrl.PercentClass}'>{entityEurBrl.PercentPlusMinusClass}{entityEurBrl.PercentString}%</span>
                                      </div>
                                    </div>
                                    <div class='linha'>
                                      <div class='esquerda'>nasdaq</div>
                                      <div class='direita'>
                                        <span> {entityNasdaq.RegularMarketPrice}</span>
                                        <span class='{entityNasdaq.PercentClass}'>{entityNasdaq.PercentPlusMinusClass}{entityNasdaq.PercentString}%</span>
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
