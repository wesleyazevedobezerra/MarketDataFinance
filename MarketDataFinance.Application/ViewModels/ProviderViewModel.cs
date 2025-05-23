using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class ProviderViewModel
    {
        public LogoViewModel Logo { get; set; }
        public string DisplayName { get; set; }
        public ProviderBrandViewModel ProviderBrand { get; set; }
        public string Id { get; set; }
        public string Url { get; set; }
        public DarkLogoViewModel DarkLogo { get; set; }
        public LightLogoViewModel LightLogo { get; set; }
        public string SourceId { get; set; }
    }

    public class ProviderNewsViewModel
    {
        public string DisplayName { get; set; }
    }
}
