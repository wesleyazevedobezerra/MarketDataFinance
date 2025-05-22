using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MarketDataFinance.Domain.Entities
{
    public class RootEntity
    {
        public DataEntity Data { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
    }

    public class SummaryRootEntity
    {
        public List<Datum> Data { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
    }
}
