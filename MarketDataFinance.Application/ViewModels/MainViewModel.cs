using MarketDataFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class MainViewModel
    {
        public List<PackageViewModel>? Packages { get; set; }
        public DataViewModel? Data { get; set; }
        public MetaViewModel? Meta { get; set; }
    }

    public class MainNewsViewModel
    {
        public bool NextPage { get; set; }
        public PaginationViewModel? Pagination { get; set; }
        public List<StreamViewModel>? Stream { get; set; }
    }
}
