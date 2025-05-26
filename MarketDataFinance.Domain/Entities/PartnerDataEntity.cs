using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class PartnerDataEntity
    {
        public string? ContentType { get; set; }
        public bool ShowPremiumPaywall { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public VideoEnrichmentEntity? VideoEnrichment { get; set; }
        public bool HasScribble { get; set; }
        public string? MostRecentPostUUID { get; set; }
        public int TotalBlogPostCount { get; set; }
        public AdMetaEntity? AdMeta { get; set; }
        public bool TpConsent { get; set; }
        public string? HostedType { get; set; }
        public string? SpaceId { get; set; }
        public string? Url { get; set; }
        public List<SlotEntity>? Slots { get; set; }
        public string? Uuid { get; set; }
        public string? Type { get; set; }
    }
}
