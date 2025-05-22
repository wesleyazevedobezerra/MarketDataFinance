using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MarketDataFinance.Domain.Entities
{
    public class ModuleEntity
    {
        public string Name { get; set; }
        public AttsEntity Atts { get; set; }
        public DataEntity Data { get; set; }
    }
}
