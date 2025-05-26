using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class CurrentTradingPeriodChartViewModel
    {

        public PreChartViewModel? pre { get; set; }
        public PostChartViewModel? post { get; set; }
        public RegularChartViewModel? regular { get; set; }
    }

  

    public class PostChartViewModel
    {
        public int end { get; set; }
        public int gmtoffset { get; set; }
        public string? timezone { get; set; }
        public int start { get; set; }
    }

    public class PreChartViewModel
    {
        public int end { get; set; }
        public int gmtoffset { get; set; }
        public string? timezone { get; set; }
        public int start { get; set; }
    }



    public class RegularChartViewModel
    {
        public int end { get; set; }
        public int gmtoffset { get; set; }
        public string? timezone { get; set; }
        public int start { get; set; }
    }
}
