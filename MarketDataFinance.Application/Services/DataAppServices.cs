using MarketDataFinance.Application.Factories;
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
        private readonly  MarketDataFinance.Domain.Contracts.Adapters.IDataAdapter _dataAdapter;
        public DataAppServices(MarketDataFinance.Domain.Contracts.Adapters.IDataAdapter dataAdapter)
        {
            _dataAdapter = dataAdapter;
        }
        public async Task<DataViewModel> SearchMarketETF()
        {
            var entity = await _dataAdapter.SearchMarketETF();
            return DataFactory.CreateDataFactory(entity);
        }
    }
}
