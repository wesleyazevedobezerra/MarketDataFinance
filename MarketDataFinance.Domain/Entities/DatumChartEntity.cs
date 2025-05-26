using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class DatumChartEntity
    {
        public List<int>? timestamp { get; set; }
        public MetaChartEntity? meta { get; set; }
        public IndicatorsChartEntity? indicators { get; set; }
    }
}
