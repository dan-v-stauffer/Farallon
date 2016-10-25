using System;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;


using FinanceEngine.Models;
using Newtonsoft.Json;
using JsonNet.PrivateSettersContractResolvers;

namespace FinanceEngine.WebServices
{
//Extenstion of FinancialWebService to leverage Google Finance API
//async method to call Google Finance API
//Singleton pattern and persistant HttpClient to keep connection open

    class GoogleFinanceService : FinancialWebService
    {
        #region Members
        private static GoogleFinanceService _instance;
        private JsonSerializerSettings _jsonSettings;
        private HttpClient _client;

        public static GoogleFinanceService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GoogleFinanceService();

                return _instance;
            }
        }
        #endregion

        #region Constructor
        private GoogleFinanceService()
        {
            _client = new HttpClient();

            //provide ability for Json Serializer to set private methods for underlying model
            _jsonSettings = new JsonSerializerSettings
            {
                ContractResolver = new PrivateSetterContractResolver()
            };
        }
        #endregion

        #region Public Methods
        public override async Task<IEquity> GetQuote(String symbol)
        {
            _url = String.Format("{0}{1}", ConfigurationManager.AppSettings["GoogleUrl"], symbol.ToUpper());

            HttpResponseMessage response = await _client.GetAsync(_url).ConfigureAwait(false);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                String json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                json = json.Replace(@"//", "").Replace("[","").Replace("]",""); //hack to strip unnecessary chars at beginning and end of json return string
                
                return JsonConvert.DeserializeObject<GoogleEquity>(json);
            }
            return null;
        }

        //public override Boolean CheckConnection()
        //{
        //    return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
        //}
        #endregion
    }
}
