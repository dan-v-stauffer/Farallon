using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace DataAccess.Models
{
    //Model for PortfolioOwner - using DataContractSerialization

    [DataContract(Name ="PortfolioOwner", Namespace ="")]
    public class PortfolioOwner
    {
        #region Members
        [DataMember(Name = "ClientId", IsRequired = true, Order = 1)]
        public Guid ID { get; private set; }

        [DataMember(Name = "FirstName", IsRequired = true, Order = 2)]
        public String FirstName { get; private set; }

        [DataMember(Name = "LastName", IsRequired = true, Order = 3)]
        public String LastName { get; private set; }

        [DataMember(Name = "PhoneNumber", IsRequired = true, Order = 4)]
        public String PhoneNumber { get; private set; }

        [DataMember(Name = "Email", IsRequired = true, Order = 5)]
        public String Email { get; private set; }
        #endregion
    }
}
