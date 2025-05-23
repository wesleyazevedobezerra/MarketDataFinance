using MarketDataFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class ChartRootViewModel
    {
        public List<DatumChartViewModel> data { get; set; }
        public string message { get; set; }
        public bool success { get; set; }
        public int code { get; set; }
    }
}
