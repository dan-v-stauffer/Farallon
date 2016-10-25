using System;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

using FinanceEngine.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JsonNet.PrivateSettersContractResolvers;

namespace FinanceEngine.WebServices
{
    //Extenstion of FinancialWebService to leverage Yahoo Finance API (API not working right now)
    //async method to call Google Finance API
    //Singleton pattern and persistant HttpClient to keep connection open

    public class YahooFinanceService : FinancialWebService
    {
        #region Members
        private static YahooFinanceService _instance;
        private JsonSerializerSettings _jsonSettings;
        private HttpClient _client;
        public static YahooFinanceService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new YahooFinanceService();
                
                return _instance;
            }
        }
        #endregion

        #region Constructor
        private YahooFinanceService()
        {
            _client = new HttpClient();
            _jsonSettings = new JsonSerializerSettings
            {
                ContractResolver = new PrivateSetterContractResolver()
            };
        }
        #endregion

        #region Public Methods
        public override async Task<IEquity> GetQuote(String symbol)
        {
            _url = String.Format("{0}", ConfigurationManager.AppSettings["YahooUrl"]).Replace("&amp;", "&").Replace("@", symbol.ToUpper());

            HttpResponseMessage response = await _client.GetAsync(_url).ConfigureAwait(false);

            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                JObject o = JObject.Parse(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
                JToken equity = o["query"]["results"]["quote"];
                YahooEquity ye = JsonConvert.DeserializeObject<YahooEquity>(equity.ToString());
                return ye;
            }
            return null;
        }
        #endregion
    }

}
