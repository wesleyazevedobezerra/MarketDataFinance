using MarketDataFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class DatumSearchNewsViewModel
    {
        public string link { get; set; }
        public string title { get; set; }
        public string uuid { get; set; }
        public ThumbnailSearchNewsViewModel thumbnail { get; set; }
        public string type { get; set; }
        public int providerPublishTime { get; set; }
        public string publisher { get; set; }
        public List<string> relatedTickers { get; set; }
    }
}
