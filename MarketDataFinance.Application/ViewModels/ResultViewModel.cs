using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class ResultViewModel
    {
        public MetaFinanceChartViewModel Meta { get; set; }
        public List<int> Timestamp { get; set; }
        public IndicatorsViewModel Indicators { get; set; }
    }
}
