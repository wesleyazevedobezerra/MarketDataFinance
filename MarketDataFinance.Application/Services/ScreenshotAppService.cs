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
            

            var ibovespaTask =  _financeChartAppService.SearchChartFinance("^BVSP");
            var usdBRLTask   =  _financeChartAppService.SearchChartFinance("USDBRL%3DX");
            var sep500Task   =  _financeChartAppService.SearchChartFinance("^GSPC");
            var eurBRLTask   =  _financeChartAppService.SearchChartFinance("EURBRL%3DX");
            var nasdaqTask   =  _financeChartAppService.SearchChartFinance("^IXIC");

            await Task.WhenAll(ibovespaTask, usdBRLTask, sep500Task, eurBRLTask, nasdaqTask);

            var entityIbovespa = ScreenshotFactory.SetEntityToViewModel(ibovespaTask.Result);
            var entityUsdBrl = ScreenshotFactory.SetEntityToViewModel(usdBRLTask.Result);
            var entitySep500 = ScreenshotFactory.SetEntityToViewModel(sep500Task.Result);
            var entityEurBrl = ScreenshotFactory.SetEntityToViewModel(eurBRLTask.Result);
            var entityNasdaq = ScreenshotFactory.SetEntityToViewModel(nasdaqTask.Result);


            string base64String = await _htmlToBase64Helper.Transform(entityIbovespa, 
                                                                      entityUsdBrl,
                                                                      entitySep500,
                                                                      entityEurBrl,
                                                                      entityNasdaq);
          

            return base64String;
        }
    }
}
