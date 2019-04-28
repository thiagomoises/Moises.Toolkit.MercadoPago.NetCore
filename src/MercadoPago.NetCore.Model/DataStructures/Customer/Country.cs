namespace MercadoPago.NetCore.Model.DataStructures.Customer
{
    public struct Country
    {
        #region Properties

        private string id;
        private string name;

        #endregion

        #region Accessors

        public string ID
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        #endregion
    }
}
