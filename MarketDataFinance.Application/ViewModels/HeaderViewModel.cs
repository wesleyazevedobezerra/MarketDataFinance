using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class HeaderViewModel
    {
        public List<PackageViewModel>? Packages { get; set; }
        public DataViewModel? Data { get; set; }
        public MetaViewModel? Meta { get; set; }
    }
}
