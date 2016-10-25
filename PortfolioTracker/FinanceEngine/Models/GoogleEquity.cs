using System;
using Newtonsoft.Json;

namespace FinanceEngine.Models
{
    //Implementation of generic IEqutiy interface for Google Quotes
    public class GoogleEquity : IEquity
    {
        #region Members
        [JsonProperty("t")]
        public String Symbol { get; private set; }

        [JsonProperty("l")]
        public Double LastTradePrice { get; private set; }
        [JsonProperty("c")]
        public Double Change { get; private set; }

        public Double Open { get { return (LastTradePrice - Change); } }

        [JsonProperty("pcls_fix")]
        public Double PreviousClose { get; private set; }

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
