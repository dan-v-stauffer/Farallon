using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceEngine.Models
{
    //Interface to allow extension of varous finace web api return models
    public interface IEquity : IComparable
    {
        String GetSymbol();
        Double GetOpenTradePrice();
        Double GetLastTradePrice();
    }
}
