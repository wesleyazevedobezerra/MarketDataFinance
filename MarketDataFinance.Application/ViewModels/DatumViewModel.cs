using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{

 

    public class DatumViewModel
    {
        public int RegularMarketTime { get; set; }
        public int SourceInterval { get; set; }
        public bool HasPrePostMarketData { get; set; }
        public string? MarketState { get; set; }
        public double RegularMarketPrice { get; set; }
        public int PostMarketTime { get; set; }
        public string? Exchange { get; set; }
        public double PostMarketChangePercent { get; set; }
        public string? QuoteSourceName { get; set; }
        public double RegularMarketChangePercent { get; set; }
        public string? CustomPriceAlertConfidence { get; set; }
        public string? ShortName { get; set; }
        public bool EsgPopulated { get; set; }
        public string? FullExchangeName { get; set; }
        public double RegularMarketPreviousClose { get; set; }
        public object? FirstTradeDateMilliseconds { get; set; }
        public string? Language { get; set; }
        public int ExchangeDataDelayedBy { get; set; }
        public int GmtOffSetMilliseconds { get; set; }
        public bool CryptoTradeable { get; set; }
        public int PriceHint { get; set; }
        public string? TypeDisp { get; set; }
        public string? ExchangeTimezoneName { get; set; }
        public string? Region { get; set; }
        public double RegularMarketChange { get; set; }
        public double PostMarketChange { get; set; }
        public string? ExchangeTimezoneShortName { get; set; }
        public string? Market { get; set; }
        public string? Symbol { get; set; }
        public bool Tradeable { get; set; }
        public string? QuoteType { get; set; }
        public double PostMarketPrice { get; set; }
        public bool Triggerable { get; set; }
        //public OptionsViewModel options { get; set; }
        public string? underlyingSymbol { get; set; }
        public QuoteViewModel? quote { get; set; }
        public bool hasMiniOptions { get; set; }
        public ExpirationDatesViewModel? expirationDates { get; set; }
        public StrikesViewModel? strikes { get; set; }
    }
}
