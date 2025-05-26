using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class MetaChartEntity
    {
        public int regularMarketTime { get; set; }
        public double fiftyTwoWeekLow { get; set; }
        public bool hasPrePostMarketData { get; set; }
        public string? range { get; set; }
        public List<string>? validRanges { get; set; }
        public string? longName { get; set; }
        public int scale { get; set; }
        public string? dataGranularity { get; set; }
        public double regularMarketPrice { get; set; }
        public int priceHint { get; set; }
        public CurrentTradingPeriodChartEntity? currentTradingPeriod { get; set; }
        public int firstTradeDate { get; set; }
        public string? exchangeTimezoneName { get; set; }
        public double previousClose { get; set; }
        public double chartPreviousClose { get; set; }
        public string? shortName { get; set; }
        public int regularMarketVolume { get; set; }
        public string? timezone { get; set; }
        public string? exchangeName { get; set; }
        public string? currency { get; set; }
        public string? instrumentType { get; set; }
        public double regularMarketDayLow { get; set; }
        public string? symbol { get; set; }
        public double regularMarketDayHigh { get; set; }
        public int gmtoffset { get; set; }
        public double fiftyTwoWeekHigh { get; set; }
        public string? fullExchangeName { get; set; }
    }
}
