using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class ResolutionSearchNewsEntity
    {
        public string? url { get; set; }
        public string? tag { get; set; }
        public int height { get; set; }
        public int width { get; set; }
    }
}
