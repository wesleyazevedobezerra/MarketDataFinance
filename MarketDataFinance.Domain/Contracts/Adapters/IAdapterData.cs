using MarketDataFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Contracts.Adapters
{
    public interface IAdapterData
    {
        Task<RootEntity> SearchMarketETF();
        Task<RootEntity> SearchMarketCrypto();

        Task<SummaryRootEntity> SearchMarketSummary(string symbol);
        Task<RootEntity> SearchMarketOverview();

        Task<SummaryRootEntity> SearchMarketSummaryRelatedList(string symbol,int limit);
    }
}
