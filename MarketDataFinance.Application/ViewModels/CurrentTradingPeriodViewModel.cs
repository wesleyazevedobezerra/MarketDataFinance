using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class CurrentTradingPeriodViewModel
    {
        public PreViewModel? Pre { get; set; }
        public RegularViewModel? Regular { get; set; }
        public PostViewModel? Post { get; set; }
    }
}
