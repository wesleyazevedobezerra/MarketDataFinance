using MarketDataFinance.Application.ViewModels;
using MarketDataFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.Interfaces
{
    public interface IDataAppServices
    {
        Task<RootViewModel> SearchMarketETF();
        Task<RootViewModel> SearchMarketCrypto();
        Task<RootViewModel> SearchMarketOverview();


    }
}
