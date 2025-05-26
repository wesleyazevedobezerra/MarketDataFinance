using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class StructuredSummaryEntity
    {
        public List<SummaryNewsEntity>? Summaries { get; set; }
        public string? Source { get; set; }
    }
}
