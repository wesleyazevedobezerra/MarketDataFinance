using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MarketDataFinance.Application.ViewModels
{
    public class FormattedBodyViewModel
    {
        public FormattingViewModel? Formatting { get; set; }
        public string? Text { get; set; }
    }
}
