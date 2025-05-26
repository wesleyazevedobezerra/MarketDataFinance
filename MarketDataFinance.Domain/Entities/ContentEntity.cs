using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class ContentEntity
    {
        public List<AuthorEntity>? Authors { get; set; }
        public List<string>? Tags { get; set; }
        public DateTime PubDate { get; set; }
        public HeroModuleEntity? HeroModule { get; set; }
        public HideAdTypesEntity? HideAdTypes { get; set; }
        public bool CommentsAllowed { get; set; }
        public object? Polls { get; set; }
        public string? ContentType { get; set; }
        public string? Summary { get; set; }
        public bool IsOpinion { get; set; }
        public string? ReadMoreList { get; set; }
        public AuthorEntity? Author { get; set; }
        public object? PreviewUrl { get; set; }
        public bool IsCreatorContent { get; set; }
        public List<XrayMetumEntity>? XrayMeta { get; set; }
        public string? Id { get; set; }
        public string AmpUrl { get; set; }
        public List<string>? EditorialTags { get; set; }
        public bool IsHosted { get; set; }
        public string? ProviderContentUrl { get; set; }
        public string? Description { get; set; }
        public ThumbnailEntity? Thumbnail { get; set; }
        public ReadingMetaEntity? ReadingMeta { get; set; }
        public StructuredSummaryEntity? StructuredSummary { get; set; }
        public string? CommerceArticleType { get; set; }
        public ProviderEntity? Provider { get; set; }
        public ClickThroughUrlEntity? ClickThroughUrl { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public CanonicalUrlEntity? CanonicalUrl { get; set; }
        public string? Subheadline { get; set; }
        public List<AudioEntity>? Audios { get; set; }
        public string? LiveBlogStatus { get; set; }
        public AdMetaEntity? AdMeta { get; set; }
        public object? Slides { get; set; }
        public string? Title { get; set; }
        public CommerceAffiliateStatEntity? CommerceAffiliateStat { get; set; }
        public DateTime DisplayTime { get; set; }
        public object? Presentation { get; set; }
        public DateTime ModifiedTime { get; set; }
        public BodyEntity? Body { get; set; }
        public string? Source { get; set; }
    }
    public class ContentNewsEntity
    {
        public string? ContentType { get; set; }
        public ThumbnailEntity? Thumbnail { get; set; }
        public string? Id { get; set; }
        public CanonicalUrlEntity? CanonicalUrl { get; set; }
        public ClickThroughUrlEntity? ClickThroughUrl { get; set; }
        public string? PreviewUrl { get; set; }
        public string? ProviderContentUrl { get; set; }
        public string? Title { get; set; }
        public bool IsHosted { get; set; }
        public ProviderNewsEntity? Provider { get; set; }
        public bool HasVideo { get; set; }
        public int Duration { get; set; }
        public DateTime PubDate { get; set; }
        public FinanceEntity? Finance { get; set; }
    }
}
