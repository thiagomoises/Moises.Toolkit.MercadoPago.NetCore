﻿namespace MercadoPago.NetCore.Model.Resources.Dataclassures.Card
{
    public class SecurityCode
    {
        #region Properties 
        private int _length;
        private string _card_location; 
        #endregion

        #region Accessors 
        /// <summary>
        /// Security code's length
        /// </summary>
        public int Length { 
            get { return  _length; } 
            set { _length = value; } 
        }
        /// <summary>
        /// Security code's card location
        /// </summary>
        public string CardLocation { 
            get { return  _card_location; }
            set { _card_location = value; } 
        }
        #endregion
    }
}
