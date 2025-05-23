using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class ProviderBrandEntity
    {
        public string DisplayName { get; set; }
        public string State { get; set; }
        public object LogoImage { get; set; }
        public object CoverImage { get; set; }
        public bool CallToActionEnabled { get; set; }
        public SocialAliasesEntity SocialAliases { get; set; }
        public string BrandId { get; set; }
        public object BrandUrl { get; set; }
        public string Description { get; set; }
        public CallToActionsEntity CallToActions { get; set; }
        public bool SameAsAuthor { get; set; }
        public SecondaryTypesEntity SecondaryTypes { get; set; }
        public bool IsCreator { get; set; }
    }
}
