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
    public class ChartAppService : IChartAppService
    {
        private readonly IAdapterData _dataAdapter;
        public ChartAppService(IAdapterData dataAdapter)
        {
            _dataAdapter = dataAdapter;
        }

        public async Task<ChartRootViewModel> SearchChart(string symbol, int limit, string range)
        {
            var entity = await _dataAdapter.SearchChart(symbol, limit, range);
            return TypeAdapter.Adapt<ChartRootEntity, ChartRootViewModel>(entity);
        }
    }
}
