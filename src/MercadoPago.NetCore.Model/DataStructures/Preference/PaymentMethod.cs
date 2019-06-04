namespace MercadoPago.NetCore.Model.Resources.Dataclassures.Preference
{
    public class PaymentMethod
    {
        #region Properties 
        
        private string _id; 
        #endregion

        #region Accessors
        /// <summary>
        /// Payment method ID
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        } 
        #endregion
    }
}
