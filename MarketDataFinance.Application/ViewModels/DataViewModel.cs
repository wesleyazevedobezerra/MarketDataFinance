using MarketDataFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public  class DataViewModel
    {
        public long LastUpdated { get; set; }
        public string? Id { get; set; }
        public int Total { get; set; }
        public bool PredefinedScr { get; set; }
        public string? Description { get; set; }
        public int VersionId { get; set; }
        public bool UseRecords { get; set; }
        public int Count { get; set; }
        public int Start { get; set; }
        public string? Title { get; set; }
        public string? LocalizedTitle { get; set; }
        public string? LocalizedSubtitle { get; set; }
        public string? LocalizedMoreInfoTitle { get; set; }
        public string? IconUrl { get; set; }
        public long CreationDate { get; set; }
        public string? RawCriteria { get; set; }
        public string? CanonicalName { get; set; }
        public string? Name { get; set; }

        public bool? IsPremium { get; set; }

        public List<QuoteViewModel>? Quotes { get; set; }
        public List<TickerViewModel>? Tickers { get; set; }
        public List<CategoryViewModel>? Categories { get; set; }
        public List<InvestorPersonaViewModel>? InvestorPersonas { get; set; }
        public List<MarketRegionViewModel>? MarketRegions { get; set; }

        public CriteriaMetaViewModel? CriteriaMeta { get; set; }
        public RegionsViewModel? Regions { get; set; }
        public MetaViewModel? Meta { get; set; }
        public DataViewModel? Data { get; set; }
        public ModuleViewModel? Module { get; set; }
    }

    
     public class DataNewsViewModel
    {
        public PartnerDataViewModel? PartnerData { get; set; }
        public string? ContentType { get; set; }
        public ContentViewModel? Content { get; set; }
        public string? Type { get; set; }
        public string? Id { get; set; }
    }

    public class DataNewsListViewModel
    {
        public MainNewsViewModel? Main { get; set; }
    }
}
