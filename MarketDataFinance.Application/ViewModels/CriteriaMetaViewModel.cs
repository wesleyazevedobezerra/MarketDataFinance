using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    internal class CriteriaMetaViewModel(string SortField, int Size, string TopOperator, List<string> IncludeFields, string SortType, string QuoteType, int Offset, List<CriterionViewModel> Criteria);
}
