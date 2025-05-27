using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class ChartEntity
    {
        public List<ResultEntity> Result { get; set; }
        public object Error { get; set; }
    }
}
