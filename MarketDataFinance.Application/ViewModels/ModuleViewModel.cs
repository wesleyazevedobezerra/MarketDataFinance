using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class ModuleViewModel
    {
        public string Name { get; set; }
        public AttsViewModel Atts { get; set; }
        public DataViewModel Data { get; set; }
    }
}
