using MarketDataFinance.Domain.Contracts.Adapters;
using MarketDataFinance.Domain.Entities;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Adapter
{
    public class AdapterData : IAdapterData
    {
        private readonly string RapidApiHostHeader;
        private readonly string RapidApiKeyValue;
        private readonly string RapidApiHostValue;
        private readonly string RapidApiKeyHeader;

        public AdapterData(IConfiguration _configuration)
        {
            RapidApiHostHeader = _configuration["RapidApi:HostHeader"] ?? string.Empty;
            RapidApiKeyValue = _configuration["RapidApi:KeyValue"] ?? string.Empty;
            RapidApiHostValue = _configuration["RapidApi:HostValue"] ?? string.Empty;
            RapidApiKeyHeader = _configuration["RapidApi:KeyHeader"] ?? string.Empty;
        }

        public async Task<RootEntity> SearchMarketCrypto()
        {
            using (HttpClient http = new HttpClient())
            {
                http.DefaultRequestHeaders.Add(RapidApiHostHeader, RapidApiHostValue);
                http.DefaultRequestHeaders.Add(RapidApiKeyHeader, RapidApiKeyValue);

                var response = await http.GetAsync($"https://yahoo-finance-api-data.p.rapidapi.com/market/crypto?screenerId=FIFTY_TWO_WK_GAINERS_CRYPTOCURRENCIES&offset=0&limit=0");
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    RootEntity? entity = JsonConvert.DeserializeObject<RootEntity>(responseBody);
                    if (entity != null)
                        return entity;
                    else
                        return new RootEntity();
                }
                return new RootEntity();
            }
        }

        public async Task<RootEntity> SearchMarketETF()
        {
            using (HttpClient http = new HttpClient())
            {
                http.DefaultRequestHeaders.Add(RapidApiHostHeader, RapidApiHostValue);
                http.DefaultRequestHeaders.Add(RapidApiKeyHeader, RapidApiKeyValue);
                var response = await http.GetAsync($"https://yahoo-finance-api-data.p.rapidapi.com/market/etf?screenerId=COMMODITY_ETFS&region=us&offset=0&limit=0");
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    RootEntity? entity = JsonConvert.DeserializeObject<RootEntity>(responseBody);
                    if (entity != null)
                        return entity;
                    else
                        return new RootEntity();
                }
                return new RootEntity();
            }
        }

        public async Task<RootEntity> SearchMarketOverview()
        {
            using (HttpClient http = new HttpClient())
            {
                http.DefaultRequestHeaders.Add(RapidApiHostHeader, RapidApiHostValue);
                http.DefaultRequestHeaders.Add(RapidApiKeyHeader, RapidApiKeyValue);
                var response = await http.GetAsync($"https://yahoo-finance-api-data.p.rapidapi.com/market/etf?screenerId=COMMODITY_ETFS&region=us&offset=0&limit=0");
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    RootEntity? entity = JsonConvert.DeserializeObject<RootEntity>(responseBody);
                    if (entity != null)
                        return entity;
                    else
                        return new RootEntity();
                }
                return new RootEntity();
            }
        }

        public async Task<SummaryRootEntity> SearchMarketSummary(string symbol)
        {
            using (HttpClient http = new HttpClient())
            {
                http.DefaultRequestHeaders.Add(RapidApiHostHeader, RapidApiHostValue);
                http.DefaultRequestHeaders.Add(RapidApiKeyHeader, RapidApiKeyValue);
                var response = await http.GetAsync($"https://yahoo-finance-api-data.p.rapidapi.com/summary/option-price?symbol={symbol}");
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    SummaryRootEntity? entity = JsonConvert.DeserializeObject<SummaryRootEntity>(responseBody);
                    if (entity != null)
                        return entity;
                    else
                        return new SummaryRootEntity();
                }
                return new SummaryRootEntity();
            }
        }

        public async Task<SummaryRootEntity> SearchMarketSummaryRelatedList(string symbol, int limit)
        {
               using (HttpClient http = new HttpClient())
            {
                http.DefaultRequestHeaders.Add(RapidApiHostHeader, RapidApiHostValue);
                http.DefaultRequestHeaders.Add(RapidApiKeyHeader, RapidApiKeyValue);
                var response = await http.GetAsync($"https://yahoo-finance-api-data.p.rapidapi.com/summary/option-price?symbol={symbol}&limit={limit}");
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    SummaryRootEntity? entity = JsonConvert.DeserializeObject<SummaryRootEntity>(responseBody);
                    if (entity != null)
                        return entity;
                    else
                        return new SummaryRootEntity();
                }
                return new SummaryRootEntity();
            }
        }



        public async Task<ChartRootEntity> SearchChart(string symbol, int limit, string range)
        {
            using (HttpClient http = new HttpClient())
            {
                http.DefaultRequestHeaders.Add(RapidApiHostHeader, RapidApiHostValue);
                http.DefaultRequestHeaders.Add(RapidApiKeyHeader, RapidApiKeyValue);
                var response = await http.GetAsync($"https://yahoo-finance-api-data.p.rapidapi.com/chart/simple-chart?symbol={symbol}&limit={limit}&range={range}");
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    ChartRootEntity? entity = JsonConvert.DeserializeObject<ChartRootEntity>(responseBody);
                    if (entity != null)
                        return entity;
                    else
                        return new ChartRootEntity();
                }
                return new ChartRootEntity();
            }
        }


        public async Task<ChartRootEntity> SearchChartAdvanced(string symbol, int limit, string from, string to, string range)
        {
            using (HttpClient http = new HttpClient())
            {
                string url = $"https://yahoo-finance-api-data.p.rapidapi.com/chart/advanced-chart?symbol={symbol}&limit={limit}&from={from}&to={to}&range={range}";
                var response = await http.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    ChartRootEntity? entity = JsonConvert.DeserializeObject<ChartRootEntity>(responseBody);
                    if (entity != null)
                        return entity;
                    else
                        return new ChartRootEntity();
                }
                return new ChartRootEntity();
            }
        }

        public async Task<SearchNewsRootEntity> SearchNews(string keyword, int limit)
        {
            using (HttpClient http = new HttpClient())
            {
                http.DefaultRequestHeaders.Add(RapidApiHostHeader, RapidApiHostValue);
                http.DefaultRequestHeaders.Add(RapidApiKeyHeader, RapidApiKeyValue);
                string url = $"https://yahoo-finance-api-data.p.rapidapi.com/search/news?keyword={keyword}&limit={limit}";
                var response = await http.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    SearchNewsRootEntity? entity = JsonConvert.DeserializeObject<SearchNewsRootEntity>(responseBody);
                    if (entity != null)
                        return entity;
                    else
                        return new SearchNewsRootEntity();
                }
                return new SearchNewsRootEntity();
            }
        }
        public async Task<RootNewsEntity> SearchMarketNewsDetail()
        {
            using (HttpClient http = new HttpClient())
            {
                http.DefaultRequestHeaders.Add(RapidApiHostHeader, RapidApiHostValue);
                http.DefaultRequestHeaders.Add(RapidApiKeyHeader, RapidApiKeyValue);
                var response = await http.GetAsync($"https://yahoo-finance-api-data.p.rapidapi.com/news/detail?id=4cd7395e-588c-4a64-a33b-64371b30dc95");
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    RootNewsEntity? entity = JsonConvert.DeserializeObject<RootNewsEntity>(responseBody);
                    if (entity != null)
                        return entity;
                    else
                        return new RootNewsEntity();
                }
                return new RootNewsEntity();
            }
        }

        public async Task<RootNewsHotEntity> SearchMarketNewsHot(int limit)
        {
            using (HttpClient http = new HttpClient())
            {
                http.DefaultRequestHeaders.Add(RapidApiHostHeader, RapidApiHostValue);
                http.DefaultRequestHeaders.Add(RapidApiKeyHeader, RapidApiKeyValue);
                var response = await http.GetAsync($"https://yahoo-finance-api-data.p.rapidapi.com/news/hot-news?limit={limit}");
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    RootNewsHotEntity? entity = JsonConvert.DeserializeObject<RootNewsHotEntity>(responseBody);
                    if (entity != null)
                        return entity;
                    else
                        return new RootNewsHotEntity();
                }
                return new RootNewsHotEntity();
            }
        }

        public async Task<RootNewsListEntity> SearchMarketNewsList(int limit)
        {
            using (HttpClient http = new HttpClient())
            {
                http.DefaultRequestHeaders.Add(RapidApiHostHeader, RapidApiHostValue);
                http.DefaultRequestHeaders.Add(RapidApiKeyHeader, RapidApiKeyValue);
                var response = await http.GetAsync($"https://yahoo-finance-api-data.p.rapidapi.com/news/hot-news?limit={limit}");
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    RootNewsListEntity? entity = JsonConvert.DeserializeObject<RootNewsListEntity>(responseBody);
                    if (entity != null)
                        return entity;
                    else
                        return new RootNewsListEntity();
                }
                return new RootNewsListEntity();
            }
        }

        public async Task<RootFinanceChartEntity> SearchChartFinance(string symbol)
        {
            using (HttpClient http = new HttpClient())
            {
                http.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
               
                var response = await http.GetAsync($"https://query1.finance.yahoo.com/v8/finance/chart/{symbol}?region=US&lang=en-US&interval=1d&range=1d");
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    RootFinanceChartEntity? entity = JsonConvert.DeserializeObject<RootFinanceChartEntity>(responseBody);
                    if (entity != null)
                        return entity;
                    else
                        return new RootFinanceChartEntity();
                }
                return new RootFinanceChartEntity();
            }
        }
    }
}


