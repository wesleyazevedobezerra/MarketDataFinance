using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class XrayMetumViewModel
    {
        public string? LongName { get; set; }
        public string? Id { get; set; }
        public bool CryptoTradeable { get; set; }
        public string? Namespace { get; set; }
        public string? ShortName { get; set; }
        public string? Type { get; set; }
    }
}
