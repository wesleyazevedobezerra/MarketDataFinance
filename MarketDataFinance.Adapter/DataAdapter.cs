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
    public class DataAdapter : Domain.Contracts.Adapters.IDataAdapter
    {
        public async Task<DataEntity> SearchMarketETF()
        {
            using (HttpClient http = new HttpClient())
            {
                var response = await http.GetAsync($"https://yahoo-finance-api-data.p.rapidapi.com/market/etf?screenerId=COMMODITY_ETFS&region=us&offset=0&limit=0");
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    DataEntity? entity = JsonConvert.DeserializeObject<DataEntity>(responseBody);
                    if (entity != null)
                        return entity;
                    else
                        return new DataEntity();
                }
                return new DataEntity();
            }
        }
    }
}


