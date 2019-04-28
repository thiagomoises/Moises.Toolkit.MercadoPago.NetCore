﻿namespace MercadoPago.NetCore.Model.DataStructures.Customer
{
    public struct Address
    {
        #region Properties 
        private string _id;
        private string _zip_code;
        private string _street_name;
        private string _street_number;
        #endregion

        #region Accessors
        /// <summary>
        /// Address ID
        /// </summary>
        public string Id { 
            get { return  _id; } 
            set { _id = value; } 
        }
        /// <summary>
        /// Zip code
        /// </summary>
        public string ZipCode {
            get { return  _zip_code; } 
            set { _zip_code = value; }
        }
        /// <summary>
        /// Street name
        /// </summary>
        public string StreetName { 
            get { return  _street_name; } 
            set { _street_name = value; } 
        }
        /// <summary>
        /// Street number
        /// </summary>
        public string StreetNumber { 
            get { return  _street_number; } 
            set { _street_number = value; } 
        }
        #endregion
    }
}
