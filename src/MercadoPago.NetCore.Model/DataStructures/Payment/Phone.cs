namespace MercadoPago.NetCore.Model.DataStructures.Payment
{
    public struct Phone
    {
        #region Properties 
        
        private string _area_code;
        
        private string _number;
        private string _extension; 
        #endregion

        #region Accessors 
        /// <summary>
        /// Phone area code
        /// </summary>
        public string AreaCode
        {
            get { return this._area_code; }
            set { this._area_code = value; }
        } 
        /// <summary>
        /// Phone number
        /// </summary>
        public string Number
        {
            get { return this._number; }
            set { this._number = value; }
        } 
        /// <summary>
        /// Phone number's extension
        /// </summary>
        public string Extension
        {
            get { return this._extension; }
            private set { this._extension = value; }
        } 
        #endregion
    }
}
