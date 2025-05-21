using MarketDataFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Contracts.Adapters
{
    public interface IDataAdapter
    {
        Task<DataEntity> SearchMarketETF();
    }
}
