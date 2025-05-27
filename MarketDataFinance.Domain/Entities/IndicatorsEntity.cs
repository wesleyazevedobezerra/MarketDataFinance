using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class IndicatorsEntity
    {
        public List<QuoteFinanceChartEntity> Quote { get; set; }
        public List<AdjcloseEntity> Adjclose { get; set; }
    }
}
