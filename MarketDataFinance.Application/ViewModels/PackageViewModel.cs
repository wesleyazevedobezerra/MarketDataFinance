using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class PackageViewModel
    {
        public string? Name { get; set; }
        public MetaViewModel? Meta { get; set; }
        public List<ModuleViewModel>? Modules { get; set; }
    }
}
