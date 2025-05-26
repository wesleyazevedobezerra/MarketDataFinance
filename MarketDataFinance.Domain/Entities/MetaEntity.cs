using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class MetaEntity
    {
        public string TemplateName { get; set; }
    }
    
    public class MetaNewsEntity
    {
        public object? LandingPageOverlay { get; set; }
        public string? LocalizedTitle { get; set; }
        public string? Id { get; set; }
        public List<FormattedBodyEntity>? FormattedBody { get; set; }
        public object? Vid { get; set; }
        public object? Tkr { get; set; }
        public string? Category { get; set; }
    }
}
