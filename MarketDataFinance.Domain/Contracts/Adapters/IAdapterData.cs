﻿using MarketDataFinance.Domain.Entities;
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

        Task<ChartRootEntity> SearchChart(string symbol, int limit, string range);

        Task<ChartRootEntity> SearchChartAdvanced(string symbol, int limit, string from, string to, string range);

        Task<SearchNewsRootEntity> SearchNews(string keyword, int limit);

        Task<RootNewsEntity> SearchMarketNewsDetail();
        Task<RootNewsHotEntity> SearchMarketNewsHot(int limit);
        Task<RootNewsListEntity> SearchMarketNewsList(int limit);

        Task<RootFinanceChartEntity> SearchChartFinance(string symbol);
    }
}
