using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class QuoteEntity
    {
        public string? MarketState { get; set; }
        public string? Exchange { get; set; }
        public double FiftyTwoWeekHighChange { get; set; }
        public string? CustomPriceAlertConfidence { get; set; }
        public long AverageDailyVolume10Day { get; set; }
        public string? ShortName { get; set; }
        public bool Triggerable { get; set; }
        public double AnnualReturnNavY3 { get; set; }
        public object? FirstTradeDateMilliseconds { get; set; }
        public string? Language { get; set; }
        public int ExchangeDataDelayedBy { get; set; }
        public bool CryptoTradeable { get; set; }
        public string? ExchangeTimezoneShortName { get; set; }
        public string? ExchangeTimezoneName { get; set; }
        public double TwoHundredDayAverage { get; set; }
        public double RegularMarketChange { get; set; }
        public double RegularMarketOpen { get; set; }
        public int BidSize { get; set; }
        public double Bid { get; set; }
        public double TwoHundredDayAverageChangePercent { get; set; }
        public double RegularMarketDayHigh { get; set; }
        public double Ask { get; set; }
        public double NetExpenseRatio { get; set; }
        public int RegularMarketTime { get; set; }
        public double FiftyTwoWeekLow { get; set; }
        public bool HasPrePostMarketData { get; set; }
        public string? MessageBoardId { get; set; }
        public string? LongName { get; set; }
        public double TrailingThreeMonthReturns { get; set; }
        public double AnnualReturnNavY5 { get; set; }
        public double RegularMarketPrice { get; set; }
        public string? QuoteSourceName { get; set; }
        public double RegularMarketChangePercent { get; set; }
        public double RegularMarketDayLow { get; set; }
        public bool Tradeable { get; set; }
        public string? FullExchangeName { get; set; }
        public double RegularMarketPreviousClose { get; set; }
        public string? Symbol { get; set; }
        public long RegularMarketVolume { get; set; }
        public double YtdReturn { get; set; }
        public string? Market { get; set; }
        public double FiftyDayAverage { get; set; }
        public string? Currency { get; set; }
        public double FiftyDayAverageChangePercent { get; set; }
        public double FiftyTwoWeekChangePercent { get; set; }
        public double FiftyDayAverageChange { get; set; }
        public int GmtOffSetMilliseconds { get; set; }
        public double DividendYield { get; set; }
        public int PriceHint { get; set; }
        public int AskSize { get; set; }
        public string? TypeDisp { get; set; }
        public long AverageDailyVolume3Month { get; set; }
        public string? QuoteType { get; set; }
        public string? RegularMarketDayRange { get; set; }
        public double FiftyTwoWeekHighChangePercent { get; set; }
        public double FiftyTwoWeekLowChange { get; set; }
        public int SourceInterval { get; set; }
        public double FiftyTwoWeekLowChangePercent { get; set; }
        public string? Region { get; set; }
        public string? FiftyTwoWeekRange { get; set; }
        public double TrailingThreeMonthNavReturns { get; set; }
        public double TwoHundredDayAverageChange { get; set; }
        public double FiftyTwoWeekHigh { get; set; }
        public long NetAssets { get; set; }
        public bool EsgPopulated { get; set; }
        public double TrailingAnnualDividendYield { get; set; }
        public double TrailingAnnualDividendRate { get; set; }
        public double DividendDate { get; set; }
        public double? EpsTrailingTwelveMonths { get; set; }
        public double? TrailingPE { get; set; }
        public double? YieldTTM { get; set; }
        public double? PeTTM { get; set; }
        public string? DisplayName { get; set; }
        public int? EarningsTimestampStart { get; set; }
        public int? EarningsTimestamp { get; set; }
        public int? EarningsTimestampEnd { get; set; }
        public int? EarningsCallTimestampStart { get; set; }
        public int? EarningsCallTimestampEnd { get; set; }
        public bool? IsEarningsDateEstimate { get; set; }
    }

    public class QuoteFinanceChartEntity
    {
        public List<double>? Low { get; set; }
        public List<long>? Volume { get; set; }
        public List<double>? High { get; set; }
        public List<double>? Open { get; set; }
        public List<double>? Close { get; set; }
    }
}
