using MarketDataFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class DatumChartViewModel
    {
        public List<int>? timestamp { get; set; }
        public MetaChartViewModel? meta { get; set; }
        public IndicatorsChartViewModel? indicators { get; set; }
    }
}
