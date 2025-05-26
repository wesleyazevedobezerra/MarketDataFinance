using MarketDataFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class ThumbnailViewModel
    {
        public string? OriginalUrl { get; set; }
        public object? Id { get; set; }
        public List<ResolutionViewModel>? Resolutions { get; set; }
        public int OriginalWidth { get; set; }
        public string? Caption { get; set; }
        public int OriginalHeight { get; set; }
    }

    public class ThumbnailNewsViewModel
    {
        public List<ResolutionViewModel>? Resolutions { get; set; }
    }
}
