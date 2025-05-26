using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class ThumbnailEntity
    {
        public string? OriginalUrl { get; set; }
        public object? Id { get; set; }
        public List<ResolutionEntity>? Resolutions { get; set; }
        public int OriginalWidth { get; set; }
        public string? Caption { get; set; }
        public int OriginalHeight { get; set; }
    }

    public class ThumbnailNewsEntity
    {
        public List<ResolutionEntity>? Resolutions { get; set; }
    }
}
