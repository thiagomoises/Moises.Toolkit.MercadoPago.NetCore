﻿namespace MercadoPago.NetCore.Model.Resources.Dataclassures.Customer
{
    public class Error
    {
        #region Properties

        private string code;
        private string description;
        private string field;                

        #endregion

        #region Accessors

        public string Code
        {
            get { return code; }            
        }

        public string Description
        {
            get { return description; }            
        }

        public string Field
        {
            get { return field; }            
        }

        #endregion
    }
}
