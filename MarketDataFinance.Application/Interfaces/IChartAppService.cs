using MarketDataFinance.Application.ViewModels;
using MarketDataFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.Interfaces
{
    public interface IChartAppService
    {
        Task<ChartRootViewModel> SearchChart(string symbol, int limit, string range);

        Task<ChartRootViewModel> SearchChartAdvanced(string symbol, int limit, string from, string to, string range);


    }
}
