using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using FinanceEngine.Models;
namespace FinanceEngine.WebServices
{
    //Generic Absract class to allow for mulitple flavors of web services
    public abstract class FinancialWebService
    {
        protected String _url;
        public abstract Task<IEquity> GetQuote(String symbol);
        public async Task<Boolean> CheckConnection()
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                string host = "8.8.8.8";
                Ping p = new Ping();
                try
                {
                    var reply = await  p.SendPingAsync(host, 3000);
                    if (reply.Status == IPStatus.Success)
                        return true;
                }
                catch
                {
                }
                return false;
            }
            return false;
        }
    }
}
