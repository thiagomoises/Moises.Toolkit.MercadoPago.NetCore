namespace MercadoPago.NetCore.Model.DataStructures.Preference
{
    public struct PaymentMethod
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
