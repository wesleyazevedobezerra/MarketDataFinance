using MarketDataFinance.Application.ViewModels;
using MarketDataFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.Interfaces
{
    public interface INewsAppService
    {
        Task<RootNewsViewModel> SearchMarketNewsDetail();
        Task<RootNewsHotViewModel> SearchMarketNewsHot(int limit);
        Task<RootNewsListViewModel> SearchMarketNewsList(int limit);
    }
}
