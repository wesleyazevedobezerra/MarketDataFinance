using MarketDataFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Contracts.Helpers
{
    public interface IHtmlToBase64Helper
    {
        Task<string> Transform(ScreenshotEntity entityIbovespa,
                                            ScreenshotEntity entityUsdBrl,
                                            ScreenshotEntity entitySep500,
                                            ScreenshotEntity entityEurBrl,
                                            ScreenshotEntity entityNasdaq
                                            );
    }
}
