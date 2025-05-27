using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class ChartViewModel
    {
        public List<ResultViewModel> Result { get; set; }
        public object Error { get; set; }
    }
}
