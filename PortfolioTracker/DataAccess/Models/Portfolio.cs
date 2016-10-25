using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace DataAccess.Models
{
    //Model for Portfolio - using DataContractSerialization

    [DataContract(Name ="Portfolio", Namespace ="")]
    public class Portfolio
    {
        #region Members
        [DataMember(Name = "PortfolioOwner", Order = 1)]
        public PortfolioOwner PortfolioOwner { get; private set; }

        [DataMember(Name = "PortfolioName", Order = 2)]
        public String PortfolioName { get; private set; }

        [DataMember(Name = "PortfolioNumber", Order = 3)]
        public String PortfolioNumber { get; private set; }

        [DataMember(Name = "Positions", Order = 4)]
        public Positions Positions { get; private set; }
        #endregion

        #region Public Methods
        public List<String> GetSymbols()
        {
            List<String> retval =  Positions.Select(s => s.Symbol).Distinct().ToList();
            return retval;
        }
        #endregion
    }
}
