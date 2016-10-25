using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace DataAccess.Models
{
    //Model for Positions (List) - using DataContractSerialization

    [CollectionDataContract(Name = "Positions", ItemName = "Position", Namespace = "")]
    public class Positions : List<Position>
    {
        public List<Position> PositionList { get; private set; }
    }

    //Model for Individual Position- using DataContractSerialization
    [DataContract(Name = "Position", Namespace = "")]
    public class Position
    {
        #region Members
        [DataMember(Name = "PositionId", IsRequired = true, Order = 1)]
        public Int32 PositionId { get; private set; }

        [DataMember(Name = "Symbol", IsRequired = true, Order = 2)]
        public String Symbol { get; private set; }

        [DataMember(Name = "Quantity", IsRequired = true, Order = 3)]
        public Double Quantity { get; private set; }
                
        [DataMember(Name = "PurchasePrice", IsRequired = true, Order = 4)]
        public Double PurchasePrice { get; private set; }

        [DataMember(Name = "PurchaseDate", IsRequired = true, Order = 5)]
        public DateTime PurchaseDate { get; private set; }
        #endregion
    }


}
