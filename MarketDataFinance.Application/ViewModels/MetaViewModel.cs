using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Application.ViewModels
{
    public class MetaViewModel
    {
        public string? TemplateName { get; set; }
    }
    public class MetaNewsViewModel
    {
        public object? LandingPageOverlay { get; set; }
        public string? LocalizedTitle { get; set; }
        public string? Id { get; set; }
        public List<FormattedBodyViewModel>? FormattedBody { get; set; }
        public object? Vid { get; set; }
        public object? Tkr { get; set; }
        public string? Category { get; set; }
    }

    public class MetaFinanceChartViewModel
    {
        public string Currency { get; set; }
        public string Symbol { get; set; }
        public string ExchangeName { get; set; }
        public string FullExchangeName { get; set; }
        public string InstrumentType { get; set; }
        public int FirstTradeDate { get; set; }
        public int RegularMarketTime { get; set; }
        public bool HasPrePostMarketData { get; set; }
        public int Gmtoffset { get; set; }
        public string Timezone { get; set; }
        public string ExchangeTimezoneName { get; set; }
        public double RegularMarketPrice { get; set; }
        public double FiftyTwoWeekHigh { get; set; }
        public double FiftyTwoWeekLow { get; set; }
        public double RegularMarketDayHigh { get; set; }
        public double RegularMarketDayLow { get; set; }
        public long RegularMarketVolume { get; set; }
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public double ChartPreviousClose { get; set; }
        public int PriceHint { get; set; }
        public CurrentTradingPeriodViewModel CurrentTradingPeriod { get; set; }
        public string DataGranularity { get; set; }
        public string Range { get; set; }
        public List<string> ValidRanges { get; set; }
    }

}
