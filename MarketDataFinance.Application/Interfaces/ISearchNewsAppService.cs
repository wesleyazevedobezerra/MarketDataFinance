using MarketDataFinance.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.Interfaces
{
    public interface ISearchNewsAppService
    {
        Task<SearchNewsRootViewModel> SearchNews(string keyword, int limite);
    }
}
