using MarketDataFinance.Application.ViewModels;
using MarketDataFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.Interfaces
{
    public interface IFinanceChartAppService
    {
        Task<RootFinanceChartViewModel> SearchChartFinance(string symbol, string region, string lang, string interval, string range);
    }
}
