using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class IndicatorsViewModel
    {
        public List<QuoteFinanceChartViewModel>? Quote { get; set; }
        public List<AdjcloseViewModel>? Adjclose { get; set; }
    }
}
