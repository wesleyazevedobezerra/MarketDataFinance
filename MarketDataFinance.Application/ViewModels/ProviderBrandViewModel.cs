using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class ProviderBrandViewModel
    {
        public string DisplayName { get; set; }
        public string State { get; set; }
        public object LogoImage { get; set; }
        public object CoverImage { get; set; }
        public bool CallToActionEnabled { get; set; }
        public SocialAliasesViewModel SocialAliases { get; set; }
        public string BrandId { get; set; }
        public object BrandUrl { get; set; }
        public string Description { get; set; }
        public CallToActionsViewModel CallToActions { get; set; }
        public bool SameAsAuthor { get; set; }
        public SecondaryTypesViewModel SecondaryTypes { get; set; }
        public bool IsCreator { get; set; }
    }
}
