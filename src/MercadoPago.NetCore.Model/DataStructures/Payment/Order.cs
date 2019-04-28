using MercadoPago.NetCore.Model.Enum;

namespace MercadoPago.NetCore.Model.DataStructures.Payment
{
    public struct Order
    {
        #region Properties  
        private OrderType? _type;
        private long? _id;

        #endregion

        #region Accessors
        /// <summary>
        /// Type of order
        /// </summary>
        public OrderType? Type { 
            get { return  _type; } 
            set { _type = value; } 
        }
        /// <summary>
        /// Id of the associated purchase order
        /// </summary>
        public long? Id1 { 
            get { return  _id; } 
            set { _id = value; } 
        } 
        #endregion
    }
}
