using MarketDataFinance.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.Interfaces
{
    public interface ISummaryAppService
    {

        Task<SummaryViewModel> SearchMarketSummary(string symbol);

        Task<SummaryViewModel> SearchMarketSummaryRelatedList(string symbol, int limit);
    }
}
