using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class StructuredSummaryViewModel
    {
        public List<SummaryNewsViewModel> Summaries { get; set; }
        public string Source { get; set; }
    }
}
