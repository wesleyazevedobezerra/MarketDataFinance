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
    public class SummaryAppService : ISummaryAppService
    {
        private readonly IAdapterData _dataAdapter;
        public SummaryAppService(IAdapterData dataAdapter)
        {
            _dataAdapter = dataAdapter;
        }

        public async Task<SummaryViewModel> SearchMarketSummary(string symbol)
        {
            var entity = await _dataAdapter.SearchMarketSummary(symbol);
            return TypeAdapter.Adapt<SummaryRootEntity, SummaryViewModel>(entity);
        }

        public async Task<SummaryViewModel> SearchMarketSummaryRelatedList(string symbol, int limit)
        {
            var entity = await _dataAdapter.SearchMarketSummaryRelatedList(symbol, limit);
            return TypeAdapter.Adapt<SummaryRootEntity, SummaryViewModel>(entity);
        }
    }
}
