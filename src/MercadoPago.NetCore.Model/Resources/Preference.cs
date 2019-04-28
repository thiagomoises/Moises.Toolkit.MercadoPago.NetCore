﻿using MercadoPago.NetCore.Model.DataStructures.Preference;
using MercadoPago.NetCore.Model.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace MercadoPago.NetCore.Model
{
    /// <summary>
    /// This API allows you to set up, during the payment process, 
    /// all the item information, any accepted means of payment and many other options.
    /// </summary>
    public class Preference
    {
        #region Properties

        private List<Item> _items;
        private Payer? _payer;
        private PaymentMethods? _payment_methods;
        private Shipment? _shipments;
        private BackUrls? _back_urls;
        private string _notification_url;
        private string _id;
        private string _init_point;
        private string _sandbox_init_point;
        private DateTime? _date_created;
        [JsonConverter(typeof(StringEnumConverter))]
        private OperationType? _operation_type;
        private string _additionalInfo;
        [JsonConverter(typeof(StringEnumConverter))]
        private AutoReturnType? _auto_return;
        private string _external_reference;
        private bool? _expires;
        private DateTime? _expiration_date_from;
        private DateTime? _expiration_dateTo;
        private int? _collector_id;
        private string _client_id;
        private string _marketplace;
        private float? _marketplace_fee;
        private DifferentialPricing? _differential_pricing;
        private long? _sponsor_id;
        private List<ProcessingMode> _processing_modes;
        private bool? _binary_mode;
        #endregion

        #region Accesors

        /// <summary>
        /// Buyer Information
        /// </summary>
        public Payer? Payer 
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
        /// Set up payment methods to be excluded from the payment process
        /// </summary>
        public PaymentMethods? PaymentMethods
        {
            get
            {
                return _payment_methods;
            }

            set
            {
                _payment_methods = value;
            }
        }
        /// <summary>
        /// Shipments information
        /// </summary>
        public Shipment? Shipments
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
        /// URLs to return to the sellers website
        /// </summary>
        public BackUrls? BackUrls
        {
            get
            {
                return _back_urls;
            }

            set
            {
                _back_urls = value;
            }
        }
        /// <summary>
        /// URL where you'd like to receive a payment notification
        /// </summary>
        public string NotificationUrl
        {
            get
            {
                return _notification_url;
            }

            set
            {
                _notification_url = value;
            }
        }
        /// <summary>
        /// Preference ID (UUID)
        /// </summary>
        public string Id 
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
        /// <summary>
        /// Checkout access URL
        /// </summary>
        public string InitPoint 
        {
            get
            {
                return _init_point;
            }

            private set
            {
                _init_point = value;
            }
        }
        /// <summary>
        /// Sandbox checkout access URL
        /// </summary>
        public string SandboxInitPoint
        {
            get
            {
                return _sandbox_init_point;
            }

            set
            {
                _sandbox_init_point = value;
            }
        }
        /// <summary>
        /// Preference's creation date
        /// </summary>
        public DateTime? Datecreated
        {
            get
            {
                return _date_created;
            }

            set
            {
                _date_created = value;
            }
        }
        /// <summary>
        /// Operation data_type
        /// </summary>
        public OperationType? OperationType
        {
            get
            {
                return _operation_type;
            }

            set
            {
                _operation_type = value;
            }
        }
        /// <summary>
        /// Additional information
        /// </summary>
        public string AdditionalInfo
        {
            get
            {
                return _additionalInfo;
            }

            set
            {
                _additionalInfo = value;
            }
        }
        /// <summary>
        /// If specified, your buyers will be redirected back to your site immediately after completing the purchase
        /// </summary>
        public AutoReturnType? AutoReturn 
        {
            get
            {
                return _auto_return;
            }

            set
            {
                _auto_return = value;
            }
        }
        /// <summary>
        /// Reference you can synchronize with your payment system
        /// </summary>
        public string ExternalReference 
        {
            get
            {
                return _external_reference;
            }

            set
            {
                _external_reference = value;
            }
        }
        /// <summary>
        /// Boolean value that determines if a preference expire
        /// </summary>
        public bool? Expires 
        {
            get
            {
                return _expires;
            }

            set
            {
                _expires = value;
            }
        }
        /// <summary>
        /// Date since the preference will be active
        /// </summary>
        public DateTime? ExpirationDateFrom 
        {
            get
            {
                return _expiration_date_from;
            }

            set
            {
                _expiration_date_from = value;
            }
        }
        /// <summary>
        /// Date when the preference will be expired
        /// </summary>
        public DateTime? ExpirationDateTo 
        {
            get
            {
                return _expiration_dateTo;
            }

            set
            {
                _expiration_dateTo = value;
            }
        }
        /// <summary>
        /// Your MercadoPago seller ID
        /// </summary>
        public int? CollectorId 
        {
            get
            {
                return _collector_id;
            }

            set
            {
                _collector_id = value;
            }
        }
        /// <summary>
        /// Application owner ID that use MercadoLibre API
        /// </summary>
        public string ClientId 
        {
            get
            {
                return _client_id;
            }

            set
            {
                _client_id = value;
            }
        }
        /// <summary>
        /// Origin of the payment. Default value: NONE
        /// </summary>
        public string Marketplace 
        {
            get
            {
                return _marketplace;
            }

            set
            {
                _marketplace = value;
            }
        }
        /// <summary>
        /// Marketplace's fee charged by application owner. Default value: 0%
        /// </summary>
        public float? Marketplace_fee 
        {
            get
            {
                return _marketplace_fee;
            }

            set
            {
                _marketplace_fee = value;
            }
        }
        /// <summary>
        /// Differential pricing configuration for this preference
        /// </summary>
        public DifferentialPricing? Differential_pricing 
        {
            get
            {
                return _differential_pricing;
            }

            set
            {
                _differential_pricing = value;
            }
        }

        public List<Item> Items
        {
            get
            {
                if (_items == null)
                {
                    _items = new List<Item>();
                }
                return _items;
            }

            set
            {
                _items = value;
            }
        }

        public long? SponsorId
        {
            get
            {
                return _sponsor_id;
            }

            set
            {
                _sponsor_id = value;
            }
        }

        public List<ProcessingMode> ProcessingModes
        {
            get
            {
                if (_processing_modes == null)
                {
                    _processing_modes = new List<ProcessingMode>();
                }
                return _processing_modes;
            }

            set
            {
                _processing_modes = value;
            }
        }

        public bool? BinaryMode
        {
            get
            {
                return _binary_mode;
            }

            set
            {
                _binary_mode = value;
            }
        }

        #endregion
    }
}
