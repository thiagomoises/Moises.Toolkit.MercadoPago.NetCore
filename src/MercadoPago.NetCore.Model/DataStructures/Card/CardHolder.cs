﻿namespace MercadoPago.NetCore.Model.DataStructures.Card
{
    public struct CardHolder
    {
        #region Properties 
        private string _name;
        private Identification _identification;
        #endregion

        #region Accessors
        /// <summary>
        /// Card holder name
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// Identification information
        /// </summary>
        public Identification Identification
        {
            get { return _identification; }
            set { _identification = value; }
        }

        #endregion
    }
}
