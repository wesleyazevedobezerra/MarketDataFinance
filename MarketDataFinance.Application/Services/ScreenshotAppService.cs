using MarketDataFinance.Application.Factories;
using MarketDataFinance.Application.Interfaces;
using MarketDataFinance.Application.ViewModels;
using MarketDataFinance.Domain.Contracts.Helpers;
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
        private readonly IHtmlToBase64Helper _htmlToBase64Helper;

        public ScreenshotAppService(IFinanceChartAppService financeChartAppService, IHtmlToBase64Helper htmlToBase64Helper)
        {
            _financeChartAppService = financeChartAppService;
            _htmlToBase64Helper = htmlToBase64Helper;
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


            string base64String = await _htmlToBase64Helper.Transform(entityIbovespa, 
                                                                      entityUsdBrl,
                                                                      entitySep500,
                                                                      entityEurBrl,
                                                                      entityNasdaq);
          

            return base64String;
        }
    }
}
