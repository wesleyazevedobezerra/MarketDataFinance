using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class ResultEntity
    {
        public MetaFinanceChartEntity Meta { get; set; }
        public List<int> Timestamp { get; set; }
        public IndicatorsEntity Indicators { get; set; }
    }
}
