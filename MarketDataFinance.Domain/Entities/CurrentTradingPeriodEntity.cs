using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class CurrentTradingPeriodEntity
    {
        public PreEntity? Pre { get; set; }
        public RegularEntity? Regular { get; set; }
        public PostEntity? Post { get; set; }
    }
}
