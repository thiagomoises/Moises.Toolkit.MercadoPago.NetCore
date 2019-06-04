namespace MercadoPago.NetCore.Model.Resources.Dataclassures.Payment
{
    public class ReceiverAddress
    {
        #region Properties 
        
        private string _street_name;
        private int _street_number;
        
        private string _zip_code;
        
        private string _floor;
        
        private string _apartment;
        #endregion

        #region Accessors 
        /// <summary>
        /// Street name
        /// </summary>
        public string StreetName
        {
            get { return  _street_name; }
            set { _street_name = value; }
        }
        /// <summary>
        /// Street name
        /// </summary>
        public int StreetNumber
        {
            get { return  _street_number; }
            set { _street_number = value; }
        }
        /// <summary>
        /// Zip code
        /// </summary>
        public string Zip_code
        {
            get { return  _zip_code; }
            set { _zip_code = value; }
        }
        /// <summary>
        /// Floor
        /// </summary>
        public string Floor
        {
            get { return  _floor; }
            set { _floor = value; }
        }
        /// <summary>
        /// Apartment
        /// </summary>
        public string Apartment
        {
            get { return  _apartment; }
            set { _apartment = value; }
        }
        #endregion
    }
}
