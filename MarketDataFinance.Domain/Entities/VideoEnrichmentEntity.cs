using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class VideoEnrichmentEntity
    {
        public string? Url { get; set; }
        public int Width { get; set; }
        public string? Uuid { get; set; }
        public int Height { get; set; }
    }
}
