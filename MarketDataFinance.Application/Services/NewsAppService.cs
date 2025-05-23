using FastMapper.NetCore;
using MarketDataFinance.Application.Interfaces;
using MarketDataFinance.Application.ViewModels;
using MarketDataFinance.Domain.Contracts.Adapters;
using MarketDataFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.Services
{
    public class NewsAppService : INewsAppService
    {
        private readonly IAdapterData _dataAdapter;

        public NewsAppService(IAdapterData dataAdapter)
        {
            _dataAdapter = dataAdapter;
        }
        public async Task<RootNewsViewModel> SearchMarketNewsDetail()
        {
            var entity = await _dataAdapter.SearchMarketNewsDetail();
            return TypeAdapter.Adapt<RootNewsEntity, RootNewsViewModel>(entity);
        }

        public async Task<RootNewsHotViewModel> SearchMarketNewsHot(int limit)
        {
            var entity = await _dataAdapter.SearchMarketNewsHot(limit);
            return TypeAdapter.Adapt<RootNewsHotEntity, RootNewsHotViewModel>(entity);
        }

        public async Task<RootNewsListViewModel> SearchMarketNewsList(int limit)
        {
            var entity = await _dataAdapter.SearchMarketNewsList(limit);
            return TypeAdapter.Adapt<RootNewsListEntity, RootNewsListViewModel>(entity);
        }
    }
}
