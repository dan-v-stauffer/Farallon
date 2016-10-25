using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using DataAccess.Models;
using FinanceEngine.WebServices;
using FinanceEngine.Models;

namespace FinanceEngine
{
    public delegate void QuoteChangedEventHandler(object sender, EventArgs e);
    public delegate void HttpBlackoutEventHandler(object sender, EventArgs e);

    //QuoteEngine creates Webservice, and periodically calls webservice, and fires an event if a  quote changes
    public class QuoteEngine
    {
        #region Members
        private Timer _timer;
        private FinancialWebService _webService;
        private Dictionary<String, IEquity> _equities = new Dictionary<string, IEquity>();

        // An event that clients can use to be notified whenever the
        // quotes of _equities change.
        public event QuoteChangedEventHandler QuoteChanged;
        public event HttpBlackoutEventHandler InternetBlackout;
        #endregion

        #region Constructor
        public QuoteEngine(List<String> symbols, String service)
        {
            setWebServiceReference(service);

            if (!_webService.CheckConnection().Result)
            {
                OnInternetBlackout(EventArgs.Empty);
                return;
            }

            foreach (String symbol in symbols)
            {
                IEquity equity = getEquityUpdate(symbol).Result;

               _equities[symbol] = equity;
            }

            _timer = new Timer(10000); //set timer to 1-minute to check for stock updates
            _timer.Elapsed += new ElapsedEventHandler(_timerElapsed);
            _timer.Start();
        }
        #endregion

        #region Public Methods
        public Double ReturnQuote(String symbol)
        {
            //return LastTradePrice corresponding to symbol input
            if (_equities.ContainsKey(symbol))
                return _equities[symbol].GetLastTradePrice();
            throw new IndexOutOfRangeException("Symbol does not exist in equities list.");
        }

        public Double ReturnOpenPrice(String symbol)
        {
            //return OpeningPrice corresponding to symbol input
            if (_equities.ContainsKey(symbol))
                return _equities[symbol].GetOpenTradePrice();
            throw new IndexOutOfRangeException("Symbol does not exist in equities list.");
        }
        public Dictionary<String, IEquity> GetEquities()
        {
            return _equities;
        }
        protected virtual void OnInternetBlackout(EventArgs e)
        {
            InternetBlackout?.Invoke(this, e);
        }
        #endregion

        #region Protected Methods
        protected virtual void OnQuoteChanged(EventArgs e)
        {
            //bubble up event to notify view models and ui that quotes have changed
            QuoteChanged?.Invoke(this, e);
        }

        #endregion

        #region Private Methods
        private void _timerElapsed(object sender, ElapsedEventArgs e)
        {
            //timer to regularly ping web service for updated quotes

            bool updatesExist = false;

            Dictionary<String, IEquity> updates = new Dictionary<string, IEquity>();
            
            //check to see if updated quotes different that quote in memory (comparing last trade price)
            _equities.Select(eq => eq.Value).ToList().ForEach(q =>
                {
                    if (!_webService.CheckConnection().Result)
                    {
                        OnInternetBlackout(EventArgs.Empty);
                        return;
                    }
                    IEquity update = getEquityUpdate(q.GetSymbol()).Result;

                    //if (update == null)
                    //    OnInternetBlackout(EventArgs.Empty);
                    //else
                    {
                        Int32 direction = q.CompareTo(update);
                        if (direction != 0)
                        {
                            updatesExist = true;
                            updates[q.GetSymbol()] = update;
                        }
                    }
                }
            );

            if (updatesExist)
            {
              //if an updated quote exists, replace quote with updated one
              updates.Select(eq => eq.Value).ToList().ForEach(q => _equities[q.GetSymbol()] = q);

            //notify everyone
              OnQuoteChanged(EventArgs.Empty);
            }
        }
        private async Task<IEquity> getEquityUpdate(String symbol)
        {
            //async method to have web service call API
            return await _webService.GetQuote(symbol);
        }
        private void setWebServiceReference(String service)
        {
            //set webservice 

            switch (service.ToLower())
            {
                case "yahoo":
                    {
                        _webService = YahooFinanceService.Instance;
                        break;
                    }
                case "google":
                    {
                        _webService = GoogleFinanceService.Instance;
                        break;
                    }
                default:
                    {
                        _webService = GoogleFinanceService.Instance;
                        break;
                    }
            }
        }
        #endregion
    }
}
