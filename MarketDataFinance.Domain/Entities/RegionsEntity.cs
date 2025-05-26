using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class RegionsEntity
    {
        public MainEntity? Main { get; set; }
        public HeaderEntity? Header { get; set; }
    }
}
