using MarketDataFinance.Domain.Contracts.Adapters;
using MarketDataFinance.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Adapter
{
    public class AdapterData : IAdapterData
    {
        public async Task<RootEntity> SearchMarketCrypto()
        {
            using (HttpClient http = new HttpClient())
            {
                http.DefaultRequestHeaders.Add("x-rapidapi-host", "yahoo-finance-api-data.p.rapidapi.com");
                http.DefaultRequestHeaders.Add("x-rapidapi-key", "5f7cb7d7eemshfead8b6141e8079p16ce7cjsne53484c89fd4");

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
                http.DefaultRequestHeaders.Add("x-rapidapi-host", "yahoo-finance-api-data.p.rapidapi.com");
                http.DefaultRequestHeaders.Add("x-rapidapi-key", "5f7cb7d7eemshfead8b6141e8079p16ce7cjsne53484c89fd4");
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
                http.DefaultRequestHeaders.Add("x-rapidapi-host", "yahoo-finance-api-data.p.rapidapi.com");
                http.DefaultRequestHeaders.Add("x-rapidapi-key", "5f7cb7d7eemshfead8b6141e8079p16ce7cjsne53484c89fd4");
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
                http.DefaultRequestHeaders.Add("x-rapidapi-host", "yahoo-finance-api-data.p.rapidapi.com");
                http.DefaultRequestHeaders.Add("x-rapidapi-key", "5f7cb7d7eemshfead8b6141e8079p16ce7cjsne53484c89fd4");
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
                http.DefaultRequestHeaders.Add("x-rapidapi-host", "yahoo-finance-api-data.p.rapidapi.com");
                http.DefaultRequestHeaders.Add("x-rapidapi-key", "5f7cb7d7eemshfead8b6141e8079p16ce7cjsne53484c89fd4");
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
                http.DefaultRequestHeaders.Add("x-rapidapi-host", "yahoo-finance-api-data.p.rapidapi.com");
                http.DefaultRequestHeaders.Add("x-rapidapi-key", "5f7cb7d7eemshfead8b6141e8079p16ce7cjsne53484c89fd4");
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
                http.DefaultRequestHeaders.Add("x-rapidapi-host", "yahoo-finance-api-data.p.rapidapi.com");
                http.DefaultRequestHeaders.Add("x-rapidapi-key", "5f7cb7d7eemshfead8b6141e8079p16ce7cjsne53484c89fd4");
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
                http.DefaultRequestHeaders.Add("x-rapidapi-host", "yahoo-finance-api-data.p.rapidapi.com");
                http.DefaultRequestHeaders.Add("x-rapidapi-key", "5f7cb7d7eemshfead8b6141e8079p16ce7cjsne53484c89fd4");
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
    }
}


