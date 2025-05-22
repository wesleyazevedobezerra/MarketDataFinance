using FastMapper.NetCore;
using MarketDataFinance.Application.Interfaces;
using MarketDataFinance.Application.ViewModels;
using MarketDataFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.Services
{
    public class DataAppServices : IDataAppServices
    {
        private readonly  MarketDataFinance.Domain.Contracts.Adapters.IAdapterData _dataAdapter;
        public DataAppServices(MarketDataFinance.Domain.Contracts.Adapters.IAdapterData dataAdapter)
        {
            _dataAdapter = dataAdapter;
        }

        public async Task<DataViewModel> SearchMarketCrypto()
        {
            var entity = await _dataAdapter.SearchMarketCrypto();
            return TypeAdapter.Adapt<DataEntity, DataViewModel>(entity);
        }

        public async Task<RootViewModel> SearchMarketETF()
        {
            var entity = await _dataAdapter.SearchMarketETF();
            return TypeAdapter.Adapt<RootEntity ,RootViewModel > (entity);
        }
    }
}
