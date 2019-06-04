using MercadoPago.NetCore.Model.Resources.Enum;

namespace MercadoPago.NetCore.Model.Resources.Dataclassures.Payment
{
    public class FeeDetail
    {
        #region Properties 
        private FeeType _type; 
        private FeePayerType _fee_payer;
        private float _amount;
        #endregion

        #region Accessors
        /// <summary> Fee detail </summary>
        public FeeType Type { 
            get { return  _type; } 
            private set { _type = value; } 
        }
        /// <summary> Who absorbs the cost </summary>
        public FeePayerType FeePayer { 
            get { return  _fee_payer; } 
            private set { _fee_payer = value; } 
        }
        /// <summary> Fee amount </summary>
        public float Amount { 
            get { return  _amount; } 
            private set { _amount = value; } 
        } 
        #endregion
    }
}
