namespace MercadoPago.NetCore.Model.Resources.Dataclassures.Preference
{
    public class PaymentType
    {
        #region Properties 
        
        private string _id;
        #endregion

        #region Accessors
        /// <summary>
        /// Payment method data_type ID
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        #endregion
    }
}
