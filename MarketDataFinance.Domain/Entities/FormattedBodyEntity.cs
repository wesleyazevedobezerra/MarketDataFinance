﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MarketDataFinance.Domain.Entities
{
    public class FormattedBodyEntity
    {
        public FormattingEntity Formatting { get; set; }
        public string Text { get; set; }
    }
}
