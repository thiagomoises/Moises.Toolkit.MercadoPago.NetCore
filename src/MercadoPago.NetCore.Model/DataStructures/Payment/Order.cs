using MercadoPago.NetCore.Model.Resources.Enum;

namespace MercadoPago.NetCore.Model.Resources.Dataclassures.Payment
{
    public class Order
    {
        #region Properties  
        private OrderType _type;
        private long _id;

        #endregion

        #region Accessors
        /// <summary>
        /// Type of order
        /// </summary>
        public OrderType Type { 
            get { return  _type; } 
            set { _type = value; } 
        }
        /// <summary>
        /// Id of the associated purchase order
        /// </summary>
        public long Id1 { 
            get { return  _id; } 
            set { _id = value; } 
        } 
        #endregion
    }
}
