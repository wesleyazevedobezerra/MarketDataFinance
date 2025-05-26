using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MarketDataFinance.Domain.Entities
{
    public class HeaderEntity
    {
        public List<PackageEntity>? Packages { get; set; }
        public DataEntity? Data { get; set; }
        public MetaEntity? Meta { get; set; }
    }
}
