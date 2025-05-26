using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class ResolutionEntity
    {
        public string? Url { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string? Tag { get; set; }
    }
}
