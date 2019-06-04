using System;
using System.Collections.Generic;

namespace MercadoPago.NetCore.Model.Resources.Dataclassures.Payment
{
    public class AdditionalInfo
    {
        #region Properties
        private String _ip_address;
        private List<Item> _items;
        private AdditionalInfoPayer _payer; 
        private Shipment _shipments;  
        private Barcode _barcode;
        #endregion

        #region Accessors
        /// <summary>
        /// List of items to be paid
        /// </summary>
        public List<Item> Items 
        {
            get
            {
                return _items;
            }

            set
            {
                _items = value;
            }
        }
        /// <summary>
        /// Buyer's information
        /// </summary>
        public AdditionalInfoPayer Payer
        {
            get
            {
                return _payer;
            }

            set
            {
                _payer = value;
            }
        }
        /// <summary>
        /// Shipping information
        /// </summary> 
        public Shipment Shipments  
        {
            get
            {
                return _shipments;
            }

            set
            {
                _shipments = value;
            }
        }
        /// <summary>
        /// Barcode information
        /// </summary>
        public Barcode Barcode 
        {
            get
            {
                return _barcode;
            }

            set
            {
                _barcode = value;
            }
        }
        /// <summary>
        /// IP Address Information
        /// </summary>
        public String IpAddress
        {
            get
            {
                return _ip_address;
            }

            set
            {
                _ip_address = value;
            }
        }
         

        #endregion
    }
}
