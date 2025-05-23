using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MarketDataFinance.Domain.Entities
{
    public class MainEntity
    {
        public List<PackageEntity> Packages { get; set; }
        public DataEntity Data { get; set; }
        public MetaEntity Meta { get; set; }
    }
    public class MainNewsEntity
    {
        public bool NextPage { get; set; }
        public PaginationEntity Pagination { get; set; }
        public List<StreamEntity> Stream { get; set; }
    }
}
