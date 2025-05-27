using MarketDataFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class RootViewModel
    {
        public DataViewModel? Data { get; set; }
        public string? Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
    }

    public class SummaryViewModel
    {
        public List<SummaryDatumViewModel>? Data { get; set; }
        public string? Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
    }

    public class SummaryDatumViewModel
    {
        public string? underlyingSymbol { get; set; }
        public QuoteViewModel? quote { get; set; }
        public bool hasMiniOptions { get; set; }
    }
    public class RootNewsViewModel
    {
        public List<DataNewsViewModel>? Data { get; set; }
        public string? Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
    }
    public class RootNewsHotViewModel
    {
        public List<DatumNewsViewModel>? Data { get; set; }
        public string? Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
    }

    public class RootNewsListViewModel
    {
        public List<DatumNewsViewModel>? Data { get; set; }
        public string? Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
    }

    public class RootFinanceChartViewModel
    {
        public ChartViewModel? Chart { get; set; }
    }
}
