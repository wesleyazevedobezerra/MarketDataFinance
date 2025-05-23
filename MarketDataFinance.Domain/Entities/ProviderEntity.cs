using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class ProviderEntity
    {
        public LogoEntity Logo { get; set; }
        public string DisplayName { get; set; }
        public ProviderBrandEntity ProviderBrand { get; set; }
        public string Id { get; set; }
        public string Url { get; set; }
        public DarkLogoEntity DarkLogo { get; set; }
        public LightLogoEntity LightLogo { get; set; }
        public string SourceId { get; set; }
    }
    public class ProviderNewsEntity
    {
        public string DisplayName { get; set; }
    }
}
