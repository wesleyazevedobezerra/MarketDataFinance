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
    public class SearchNewsAppService : ISearchNewsAppService
    {
        private readonly MarketDataFinance.Domain.Contracts.Adapters.IAdapterData _dataAdapter;
        public SearchNewsAppService(IAdapterData dataAdapter)
        {
            _dataAdapter = dataAdapter;
        }
        public async Task<SearchNewsRootViewModel> SearchNews(string keyword, int limite)
        {

            var entity = await _dataAdapter.SearchNews(keyword, limite);
            return TypeAdapter.Adapt<SearchNewsRootEntity, SearchNewsRootViewModel>(entity);
        }
    }
}
