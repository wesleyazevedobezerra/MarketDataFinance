using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class QuoteChartViewModel
    {
        public List<double?>? open { get; set; }
        public List<double?>? low { get; set; }
        public List<double?>? close { get; set; }
        public List<int?>? volume { get; set; }
        public List<double?>? high { get; set; }
    }
}
