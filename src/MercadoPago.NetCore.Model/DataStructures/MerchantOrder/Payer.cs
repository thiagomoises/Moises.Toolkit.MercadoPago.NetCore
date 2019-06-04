﻿namespace MercadoPago.NetCore.Model.Resources.Dataclassures.MerchantOrder
{
    public class Payer
    {
        #region Properties

        private string id;
        private string email;
        private string nickName;

        #endregion

        #region Accessors

        public string Id
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
