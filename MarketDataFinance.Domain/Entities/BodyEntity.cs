﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MarketDataFinance.Domain.Entities
{
    public class BodyEntity
    {
        public string? Markup { get; set; }
        public DataNews? Data { get; set; }
    }
}
