using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.Interfaces
{
    public interface IScreenshotAppService
    {
        Task<string> GetScreenshotBase64Async();
    }
}
