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
    public class FinanceChartAppService : IFinanceChartAppService
    {
        private readonly IAdapterData _dataAdapter;
        public FinanceChartAppService(IAdapterData dataAdapter)
        {
            _dataAdapter = dataAdapter;
        }
        public async Task<RootFinanceChartViewModel> SearchChartFinance(string symbol)
        {
            var entity = await _dataAdapter.SearchChartFinance(symbol);
            if (entity.Chart == null)
            {
                return new RootFinanceChartViewModel();
            }

            return TypeAdapter.Adapt<RootFinanceChartEntity, RootFinanceChartViewModel>(entity);
        }
    }
}
