namespace MercadoPago.NetCore.Model.Resources.Dataclassures.MerchantOrder
{
    public class Address
    {
        #region Properties

        
        private string zipCode;
        
        private string streetName;
        private int streetNumber;
        
        private string floor;
        
        private string apartment;
        
        #endregion

        #region Accessors

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        public string StreetName
        {
            get { return streetName; }
            set { streetName = value; }
        }

        public int StreetNumber
        {
            get { return streetNumber; }
            set { streetNumber = value; }
        }

        public string Floor
        {
            get { return floor; }
            set { floor = value; }
        }

        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

        #endregion
    }
}
