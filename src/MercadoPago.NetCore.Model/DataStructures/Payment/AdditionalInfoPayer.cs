﻿using System;

namespace MercadoPago.NetCore.Model.Resources.Dataclassures.Payment
{
    public class AdditionalInfoPayer
    {
        #region Properties 
        private String _first_name;
        private String _last_name;
        private Phone _phone;
        private Address _address;
        private DateTime _registration_date; 
        #endregion

        #region Accessors

        public String FirstName
        {            
            set { _first_name = value; }
            get { return _first_name; }
        }
       
        public String LastName
        {            
            set { _last_name = value; }
            get { return _last_name; }
        }
       
        public Phone Phone
        {            
            set { _phone = value; }
            get { return _phone; }
        }
       
        public Address Address
        {            
            set { _address = value; }
            get { return _address; }
        }
       
        public DateTime RegistrationDate
        {            
            set { _registration_date = value; }
            get { return _registration_date; }
        }

        #endregion
    }
}
