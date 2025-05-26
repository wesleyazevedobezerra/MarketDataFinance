using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class CriteriaMetaEntity
    {
        public string? SortField { get; set; }
        public int Size { get; set; }
        public string? TopOperator { get; set; }
        public List<string>? IncludeFields { get; set; }
        public string? SortType { get; set; }
        public string? QuoteType { get; set; }
        public int Offset { get; set; }
        public List<CriterionEntity>? Criteria { get; set; }
    }
}
