using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class BodyViewModel
    {
        public SchemaViewModel? Schema { get; set; }
        public string? Markup { get; set; }
        public DataViewModel? Data { get; set; }
        public ModulesViewModel? Modules { get; set; }
    }
}
