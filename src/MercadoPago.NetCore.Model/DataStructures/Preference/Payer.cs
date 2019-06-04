﻿using System;

namespace MercadoPago.NetCore.Model.Resources.Dataclassures.Preference
{
    public class Payer
    {
        #region Properties 
        
        private string _name;
        
        private string _surname;
        
        private string _email;
        private Phone _phone;
        private Identification _identification;
        private Address _address;
        private DateTime _date_created; 
        #endregion

        #region Accessors
        /// <summary>
        /// Buyer name
        /// </summary>
        public string Name {
            get { return  _name; } 
            set { _name = value; }
        }
        /// <summary>
        /// Buyer last name
        /// </summary>
        public string Surname {
            get { return  _surname; } 
            set { _surname = value; }
        }
        /// <summary>
        /// Buyer e-mail address
        /// </summary>
        public string Email {
            get { return  _email; } 
            set { _email = value; }
        }
        /// <summary>
        /// Buyer phone
        /// </summary>
        public Phone Phone { 
            get { return  _phone; } 
            set { _phone = value; } 
        }
        /// <summary>
        /// Personal identification
        /// </summary>
        public Identification Identification 
        { 
            get { return  _identification; } 
            set { _identification = value; } 
        }
        /// <summary>
        /// Buyer address
        /// </summary>
        public Address Address
        {
            get { return  _address; }
            set { _address = value; }
        }
        /// <summary>
        /// Registration date
        /// </summary>
        public DateTime DateCreated 
        { 
            get { return  _date_created; }
            set { _date_created = value; }
        } 
        #endregion
    }
}
