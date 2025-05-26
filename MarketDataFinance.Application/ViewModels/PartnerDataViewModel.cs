using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class PartnerDataViewModel
    {
        public string? ContentType { get; set; }
        public bool ShowPremiumPaywall { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public VideoEnrichmentViewModel? VideoEnrichment { get; set; }
        public bool HasScribble { get; set; }
        public string? MostRecentPostUUID { get; set; }
        public int TotalBlogPostCount { get; set; }
        public AdMetaViewModel? AdMeta { get; set; }
        public bool TpConsent { get; set; }
        public string? HostedType { get; set; }
        public string? SpaceId { get; set; }
        public string? Url { get; set; }
        public List<SlotViewModel>? Slots { get; set; }
        public string? Uuid { get; set; }
        public string? Type { get; set; }
    }
}
