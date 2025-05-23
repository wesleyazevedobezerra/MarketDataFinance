using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class IndicatorsChartEntity
    {
        public List<QuoteChartEntity> quote { get; set; }
    }
}
