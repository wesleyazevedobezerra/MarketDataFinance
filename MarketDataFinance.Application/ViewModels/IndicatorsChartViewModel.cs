using MarketDataFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class IndicatorsChartViewModel
    {

        public List<QuoteChartViewModel> quote { get; set; }
    }
}
