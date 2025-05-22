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
        public DataViewModel Data { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
    }

    public class SummaryViewModel
    {
        public List<DatumViewModel> Data { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
        public int Code { get; set; }
    }

    public class DatumViewModel
    {
        public OptionsViewModel options { get; set; }
        public string underlyingSymbol { get; set; }
        public QuoteViewModel quote { get; set; }
        public bool hasMiniOptions { get; set; }
        public ExpirationDatesViewModel expirationDates { get; set; }
        public StrikesViewModel strikes { get; set; }
    }

    public class ExpirationDatesViewModel
    {
    }
    public class StrikesViewModel
    {
    }
    public class OptionsViewModel
    {
    }
}
