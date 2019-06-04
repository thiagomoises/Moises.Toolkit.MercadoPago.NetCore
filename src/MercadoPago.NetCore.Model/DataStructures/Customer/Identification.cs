namespace MercadoPago.NetCore.Model.Resources.Dataclassures.Customer
{
    public class Identification
    {
        #region Properties 
        private string _type;
        private string _number; 
        private string _defaultAddress;
        #endregion

        #region Accessors
        /// <summary>
        /// Identification's type
        /// </summary>
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        /// <summary>
        /// Identification's number
        /// </summary>
        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }
        /// <summary>
        /// Default address
        /// </summary>
        public string DefaultAddress
        {
            get { return _defaultAddress; }
            set { _defaultAddress = value; }
        }
        #endregion
    }
}
