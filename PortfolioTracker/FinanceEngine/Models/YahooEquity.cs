using System;
using System.Reflection;

using Newtonsoft.Json;

namespace FinanceEngine.Models
{
    //Implementation of generic IEqutiy interface for Yahoo Finance Quotes

    public class YahooEquity : IEquity
    {
        #region Members
        [JsonProperty]
        public String Symbol { get; private set; }

        [JsonProperty("LastTradePriceOnly")]
        public Double LastTradePrice { get; private set; }
        [JsonProperty]
        public Double Change { get; private set; }

        [JsonProperty]
        public String Currency { get; private set; }

        [JsonProperty]
        public DateTime LastTradeDate { get; private set; }

        [JsonProperty]
        public Double DaysLow { get; private set; }

        [JsonProperty]
        public Double DaysHigh { get; private set; }

        [JsonProperty]
        public Double YearLow { get; private set; }

        [JsonProperty]
        public Double YearHigh { get; private set; }

        [JsonProperty]
        public String MarketCapitalization { get; private set; }

        [JsonProperty]
        public String DaysRange { get; private set; }

        [JsonProperty]
        public String Name { get; private set; }

        [JsonProperty]
        public Double Open { get; private set; }

        [JsonProperty]
        public Double PreviousClose { get; private set; }

        [JsonProperty]
        public long Volume { get; private set; }

        #endregion

        #region IEquity Interface Methods
        public String GetSymbol()
        {
            return Symbol;
        }

        public Double GetLastTradePrice()
        {
            return LastTradePrice;
        }

        public Double GetOpenTradePrice()
        {
            return Open;
        }
        public int CompareTo(object other)
        {
            if (other == null)
                return 1;
            IEquity equity = other as IEquity;

            if (equity != null)
                return this.LastTradePrice.CompareTo(equity.GetLastTradePrice());
            else
                throw new ArgumentException("Object is not an IEqutiy.");
        }

        #endregion
    }
}
