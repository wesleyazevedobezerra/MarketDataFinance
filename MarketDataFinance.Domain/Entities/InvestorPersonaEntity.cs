using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class InvestorPersonaEntity
    {
        public string LocalizedTitle { get; set; }
        public string LocalizedDescription { get; set; }
        public string LocalizedShortTitle { get; set; }
        public string Id { get; set; }
    }
}
