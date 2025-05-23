using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class ChartRootEntity
    {
        public List<DatumChartEntity> data { get; set; }
        public string message { get; set; }
        public bool success { get; set; }
        public int code { get; set; }
    }
}
