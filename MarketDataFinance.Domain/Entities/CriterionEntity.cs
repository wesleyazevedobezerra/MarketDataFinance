using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class CriterionEntity
    {
        public List<int> LabelsSelected { get; set; }
        public object SubField { get; set; }
        public string Field { get; set; }
        public DependentValuesEntity DependentValues { get; set; }
        public List<string> Operators { get; set; }
        public ValuesEntity Values { get; set; }
    }
}
