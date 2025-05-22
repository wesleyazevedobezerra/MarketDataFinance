using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class PackageEntity
    {
        public string Name { get; set; }
        public MetaEntity Meta { get; set; }
        public List<ModuleEntity> Modules { get; set; }
    }
}
