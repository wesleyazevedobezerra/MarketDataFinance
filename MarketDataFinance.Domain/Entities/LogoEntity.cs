using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class LogoEntity
    {
        public string? OriginalUrl { get; set; }
        public int OriginalWidth { get; set; }
        public List<ResolutionEntity>? Resolutions { get; set; }
        public string? Type { get; set; }
        public int OriginalHeight { get; set; }
    }
}
