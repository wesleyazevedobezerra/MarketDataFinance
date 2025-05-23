using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class AdMetaViewModel
    {
        public string WikiIds { get; set; }
        public string Rs { get; set; }
        public string SpaceId { get; set; }
        public string YctIds { get; set; }
        public string PageUrl { get; set; }
        public object Site { get; set; }
        public string SiteAttribute { get; set; }
        public string Hashtag { get; set; }
        public string IsSupplySegment { get; set; }
        public string Region { get; set; }
        public string Lang { get; set; }
        public bool Enabled { get; set; }
        public bool ShowBodyAds { get; set; }
        public string Pos { get; set; }
        public bool ShowPhotoAds { get; set; }
    }
}
