using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class FinanceEntity
    {
        public PremiumFinanceEntity? PremiumFinance { get; set; }
        public List<StockTickerEntity>? StockTickers { get; set; }
    }
}
