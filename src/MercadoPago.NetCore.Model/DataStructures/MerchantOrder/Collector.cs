﻿namespace MercadoPago.NetCore.Model.DataStructures.MerchantOrder
{
    public struct Collector
    {
        #region Properties

        private string id;
        private string email;
        private string nickName;

        #endregion

        #region Accessors

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }

        #endregion
    }
}
