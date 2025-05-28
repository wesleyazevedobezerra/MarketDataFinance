using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDataFinance.Domain.Entities
{
    public class ScreenshotEntity
    {
        public ScreenshotEntity(MetaFinanceChartEntity meta)
        {
            this.OneHundredPercent = 100;
            this.symbol = meta.Symbol;
            this.MarketPrice =  meta.RegularMarketPrice;
            this.ChartPreviousClose = meta.ChartPreviousClose;
        } 
        //Comentario

        public double MarketPrice { get; set; }

        public string symbol { get; set; }
         
        public string RegularMarketPrice {
            get
            {
                if (this.symbol.Contains("BRL") || this.symbol.Contains("^IXIC"))
                    return this.MarketPrice.ToString("N2").Replace(",", ".");
                else
                    return Math.Truncate(this.MarketPrice).ToString("N0").Replace(",", ".");
            }
        }

        public double ChartPreviousClose { get; set; }

        private double OneHundredPercent { get; set; }

        public double Percentual 
            => ((this.MarketPrice - this.ChartPreviousClose) / this.ChartPreviousClose) * OneHundredPercent;
        
        public string PercentString  
            => ((this.Percentual < 0) ? (this.Percentual * -1) : this.Percentual).ToString("N2").Replace(",", ".");
         
        public string PercentClass 
            => this.Percentual >= 0 ? "positivo" : "negativo";
        
        public string PercentPlusMinusClass 
            => this.Percentual >= 0 ? "+" : "-";
        
    }
}
