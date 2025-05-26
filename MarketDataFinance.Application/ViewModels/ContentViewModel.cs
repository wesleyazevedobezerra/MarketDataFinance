using MarketDataFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class ContentViewModel
    {
        public List<AuthorViewModel>? Authors { get; set; }
        public List<string>? Tags { get; set; }
        public DateTime PubDate { get; set; }
        public HeroModuleViewModel? HeroModule { get; set; }
        public HideAdTypesViewModel? HideAdTypes { get; set; }
        public bool CommentsAllowed { get; set; }
        public object? Polls { get; set; }
        public string? ContentType { get; set; }
        public string? Summary { get; set; }
        public bool IsOpinion { get; set; }
        public string? ReadMoreList { get; set; }
        public AuthorViewModel? Author { get; set; }
        public object? PreviewUrl { get; set; }
        public bool IsCreatorContent { get; set; }
        public List<XrayMetumViewModel>? XrayMeta { get; set; }
        public string? Id { get; set; }
        public string? AmpUrl { get; set; }
        public List<string>? EditorialTags { get; set; }
        public bool IsHosted { get; set; }
        public string? ProviderContentUrl { get; set; }
        public string Description { get; set; }
        public ThumbnailViewModel? Thumbnail { get; set; }
        public ReadingMetaViewModel? ReadingMeta { get; set; }
        public StructuredSummaryViewModel? StructuredSummary { get; set; }
        public string? CommerceArticleType { get; set; }
        public ProviderViewModel? Provider { get; set; }
        public ClickThroughUrlViewModel? ClickThroughUrl { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public CanonicalUrlViewModel? CanonicalUrl { get; set; }
        public string? Subheadline { get; set; }
        public List<AudioViewModel>? Audios { get; set; }
        public string? LiveBlogStatus { get; set; }
        public AdMetaViewModel? AdMeta { get; set; }
        public object? Slides { get; set; }
        public string? Title { get; set; }
        public CommerceAffiliateStatViewModel? CommerceAffiliateStat { get; set; }
        public DateTime DisplayTime { get; set; }
        public object? Presentation { get; set; }
        public DateTime ModifiedTime { get; set; }
        public BodyViewModel? Body { get; set; }
        public string? Source { get; set; }
    }

    public class ContentNewsViewModel
    {
        public string? ContentType { get; set; }
        public ThumbnailViewModel? Thumbnail { get; set; }
        public string? Id { get; set; }
        public CanonicalUrlViewModel? CanonicalUrl { get; set; }
        public ClickThroughUrlViewModel? ClickThroughUrl { get; set; }
        public string? PreviewUrl { get; set; }
        public string? ProviderContentUrl { get; set; }
        public string? Title { get; set; }
        public bool IsHosted { get; set; }
        public ProviderNewsViewModel? Provider { get; set; }
        public bool HasVideo { get; set; }
        public int Duration { get; set; }
        public DateTime PubDate { get; set; }
        public FinanceViewModel? Finance { get; set; }
    }
}
