namespace MercadoPago.NetCore.Model.Resources.Dataclassures.MerchantOrder
{
    public class Item
    {
        #region Properties

        private string id;
        private string categoryId;        
        private string currencyId;
        private string description;
        private string pictureUrl;
        private int quantity;
        private float unitPrice;
        private string title;

        #endregion

        #region Accessors

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        public string CurrencyId
        {
            get { return currencyId; }
            set { currencyId = value; }
        }
       
        public string Description
        {
            get { return description; }
            set { description = value; }
        }        

        public string PictureUrl
        {
            get { return pictureUrl; }
            set { pictureUrl = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public float UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        #endregion
    }
}
