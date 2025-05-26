using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class StreamEntity
    {
        public ContentNewsEntity? Content { get; set; }
        public string? Id { get; set; }
    }
}
