using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class CurrentTradingPeriodChartEntity
    {
        public PreChartEntity? pre { get; set; }
        public PostChartEntity? post { get; set; }
        public RegularChartEntity? regular { get; set; }
    }

    public class PostChartEntity
    {
        public int end { get; set; }
        public int gmtoffset { get; set; }
        public string? timezone { get; set; }
        public int start { get; set; }
    }

    public class PreChartEntity
    {
        public int end { get; set; }
        public int gmtoffset { get; set; }
        public string? timezone { get; set; }
        public int start { get; set; }
    }



    public class RegularChartEntity
    {
        public int end { get; set; }
        public int gmtoffset { get; set; }
        public string? timezone { get; set; }
        public int start { get; set; }
    }
}
