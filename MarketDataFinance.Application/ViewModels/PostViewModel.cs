using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class PostViewModel
    {
        public string? Timezone { get; set; }
        public int End { get; set; }
        public int Start { get; set; }
        public int Gmtoffset { get; set; }
    }
}
