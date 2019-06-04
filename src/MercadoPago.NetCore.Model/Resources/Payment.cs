using MercadoPago.NetCore.Model.Resources.Dataclassures.Payment;
using MercadoPago.NetCore.Model.Resources.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace MercadoPago.NetCore.Model.Resources
{

    /// <summary>
    /// This service allows you to create, modify or read payments
    /// </summary>
    public class Payment
    {
        #region Properties 
        private long _id;
        private DateTime _date_created;
        private DateTime _date_approved;
        private DateTime _date_last_updated;
        private DateTime _money_release_date;
        private int _collector_id; 
        [JsonConverter(typeof(StringEnumConverter))]
        private OperationType _operation_type;
        private Payer _payer;
        private bool _binary_mode;
        private bool _live_mode;
        private Order _order ;
        private string _external_reference;
        private string _description;
        private JObject _metadata;
        [JsonConverter(typeof(StringEnumConverter))]
        private CurrencyId _currency_id;
        private float _transaction_amount;
        private float _transaction_amount_refunded;
        private float _coupon_amount;
        private int _campaign_id;
        private string _coupon_code;
        private TransactionDetail _transaction_details;
        private List<FeeDetail> _fee_details;
        private int _differential_pricing_id;
        private float _application_fee;  
        [JsonConverter(typeof(StringEnumConverter))]
        private PaymentStatus _status;         
        private string _status_detail;
        private bool _capture ;
        private bool _captured;
        private string _call_for_authorize_id;
        private string _payment_method_id;
        private string _issuer_id; 
        [JsonConverter(typeof(StringEnumConverter))]
        private PaymentTypeId _payment_type_id;        
        private string _token ;
        private Dataclassures.Payment.Card _card;
        private string _statement_descriptor;
        private int _installments ;
        private string _notification_url;
        private string _callback_url;
        private List<Refund> _refunds;
        private AdditionalInfo _additional_info; 
        private string _processing_mode;
        private string _merchant_account_id;
        private DateTime _date_of_expiration;
        private long _sponsor_id;
        #endregion

        #region Accessors 
        /// <summary>
        /// Payment identifier
        /// </summary>
        public long Id
        {
            get { return this._id; }
            private set { this._id = value; }
        } 
        /// <summary>
        /// Payment’s creation date
        /// </summary>
        public DateTime DateCreated 
        {
            get { return this._date_created; }
            private set { this._date_created = value; }
        } 
        /// <summary>
        /// Payment’s approval date
        /// </summary>
        public DateTime DateApproved
        {
            get { return this._date_approved; }
            private set { this._date_approved = value; }
        } 
        /// <summary>
        /// Last modified date
        /// </summary>
        public DateTime DateLastUpdated
        {
            get { return this._date_last_updated; }
            private set { this._date_last_updated = value; }
        } 
        /// <summary>
        /// Release date of payment
        /// </summary>
        public DateTime MoneyReleaseDate
        {
            get { return this._money_release_date; }
            private set { this._money_release_date = value; }
        } 
        /// <summary>
        /// Identifies the seller
        /// </summary>
        public int CollectorId
        {
            get { return this._collector_id; }
            private set { this._collector_id = value; }
        } 
        /// <summary>
        /// Payment type
        /// </summary>
        public OperationType OperationType 
        {
            get { return this._operation_type; }
            private set { this._operation_type = value; }
        } 
        /// <summary>
        /// Identifies the buyer  
        /// </summary>
        public Payer Payer 
        {
            get { return this._payer; }
            set { this._payer = value; }
        } 
        /// <summary>
        /// When set to true, the payment can only be approved or rejected. 
        /// Otherwise in_process status is added
        /// </summary>
        public bool BinaryMode
        {
            get { return this._binary_mode; }
            set { this._binary_mode = value; }
        } 
        /// <summary>
        /// Whether the payment will be processed in sandbox or in production mode
        /// </summary>
        public bool LiveMode
        {
            get { return this._live_mode; }
            private set { this._live_mode = value; }
        } 
        /// <summary>
        /// Order identifier
        /// </summary>
        public Order Order
        {
            get { return this._order; }
            set { this._order = value; }
        } 
        /// <summary>
        /// ID given by the merchant in their system
        /// </summary>
        public string ExternalReference
        {
            get { return this._external_reference; }
            set { this._external_reference = value; }
        } 
        /// <summary>
        /// Payment reason or item title
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        } 
        /// <summary>
        /// Valid JSON that can be attached to the payment to record additional attributes of the merchant
        /// </summary>
        public JObject Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        } 
        /// <summary>
        /// ID of the currency used in the payment
        /// </summary>
        public CurrencyId CurrencyId
        {
            get { return this._currency_id; }
            private set { this._currency_id = value; }
        } 
        /// <summary>
        /// Product cost
        /// </summary>
        public float TransactionAmount
        {
            get { return this._transaction_amount; }
            set { this._transaction_amount = value; }
        } 
        /// <summary>
        /// Total refunded amount in this payment
        /// </summary>
        public float TransactionAmountRefunded
        {
            get { return this._transaction_amount_refunded; }
            private set { this._transaction_amount_refunded = value; }
        } 
        /// <summary>
        /// Amount of the coupon discount
        /// </summary>
        public float CouponAmount
        {
            get { return this._coupon_amount; }
            set { this._coupon_amount = value; }
        } 
        /// <summary>
        /// Discount campaign ID
        /// </summary>
        public int CampaignId
        {
            private get { return this._campaign_id; }
            set { this._campaign_id = value; }
        } 
        /// <summary>
        /// Discount campaign with a specific code
        /// </summary>
        public string CouponCode
        {
            private get { return this._coupon_code; }
            set { this._coupon_code = value; }
        } 
        /// <summary>
        /// Groups the details of the transaction
        /// </summary>
        public TransactionDetail TransactionDetails
        {
            get { return this._transaction_details; }
            private set { this._transaction_details = value; }
        } 
        /// <summary>
        /// List of fees
        /// </summary>
        public List<FeeDetail> FeeDetails
        {
            get { return this._fee_details; }
            private set { this._fee_details = value; }
        } 
        /// <summary>
        /// Id of the scheme for the absorption of financing fee
        /// </summary>
        public int DifferentialPricingId
        {
            get { return this._differential_pricing_id; }
            set { this._differential_pricing_id = value; }
        } 
        /// <summary>
        /// Fee collected by a marketplace or MercadoPago Application
        /// </summary>
        public float ApplicationFee
        {
            private get { return this._application_fee; }
            set { this._application_fee = value; }
        } 
        /// <summary>
        /// Payment status
        /// </summary>
        public PaymentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        } 
        /// <summary>
        /// Gives more detailed information on the current state or rejection cause
        /// </summary>
        public string StatusDetail
        {
            get { return this._status_detail; }
            private set { this._status_detail = value; }
        } 
        /// <summary>
        /// Gives more detailed information on the current state or rejection cause
        /// </summary>
        public bool Capture
        {
            private get { return this._capture; }
            set { this._capture = value; }
        } 
        /// <summary>
        /// Gives more detailed information on the current state or rejection cause
        /// </summary>
        public bool Captured
        {
            get { return this._captured; }
            private set { this._captured = value; }
        } 
        /// <summary>
        /// Gives more detailed information on the current state or rejection cause
        /// </summary>
        public string CallForAuthorizeId
        {
            get { return this._call_for_authorize_id; }
            private set { this._call_for_authorize_id = value; }
        } 
        /// <summary>
        /// Gives more detailed information on the current state or rejection cause
        /// </summary>
        public string PaymentMethodId
        {
            get { return this._payment_method_id; }
            set { this._payment_method_id = value; }
        } 
        /// <summary>
        /// Payment method issuer
        /// </summary>
        public string IssuerId
        {
            get { return this._issuer_id; }
            set { this._issuer_id = value; }
        } 
        /// <summary>
        /// Type of payment method chosen
        /// </summary>
        public PaymentTypeId PaymentTypeId
        {
            get { return this._payment_type_id; }
            private set { this._payment_type_id = value; }
        } 
        /// <summary>
        /// Card token ID
        /// </summary>
        public string Token
        {
            private get { return this._token; }
            set { this._token = value; }
        } 
        /// <summary>
        /// Details of the card used
        /// </summary>
        public Dataclassures.Payment.Card Card
        {
            get { return this._card; }
            private set { this._card = value; }
        } 
        /// <summary>
        /// How will look the payment in the card bill (e.g.: MERCADOPAGO)
        /// </summary>
        public string StatementDescriptor
        {
            get { return this._statement_descriptor; }
            set { this._statement_descriptor = value; }
        } 
        /// <summary>
        /// Selected quantity of installments
        /// </summary>
        public int Installments
        {
            get { return this._installments; }
            set { this._installments = value; }
        } 
        /// <summary>
        /// URL where mercadopago will send notifications associated to changes in this payment
        /// </summary>
        public string NotificationUrl
        {
            get { return this._notification_url; }
            set { this._notification_url = value; }
        } 
        /// <summary>
        /// URL where mercadopago does the final redirect (only for bank transfers)
        /// </summary>
        public string CallbackUrl
        {
            get { return this._callback_url; }
            set { this._callback_url = value; }
        } 
        /// <summary>
        /// List of refunds that were made to this payment
        /// </summary>
        public List<Refund> Refunds
        {
            get { return this._refunds; }
            private set { this._refunds = value; }
        } 
        /// <summary>
        /// Data that could improve fraud analysis and conversion rates. 
        /// Try to send as much information as possible.
        /// </summary>
        public AdditionalInfo AdditionalInfo
        {
            get { return this._additional_info; }
            set { this._additional_info = value; }
        }
        /// <summary>
        /// Processing mode to define if an specific merchannt id should be used.
        /// </summary>
        public string ProcessingMode
        {
            get { return this._processing_mode; }
            set { this._processing_mode = value; }
        }
        /// <summary>
        /// Merchant Id for complex payment cases
        /// </summary>
        public string MerchantAccountId
        {
            get { return _merchant_account_id; }
            set { _merchant_account_id = value; }
        }

        public DateTime DateOfExpiration
        {
            get { return _date_of_expiration; } 
            set { _date_of_expiration = value; }
        }

        /// <summary>
        /// Sponsor Identification
        /// </summary>
        public long SponsorId
        {
            get { return _sponsor_id; } 
            set { _sponsor_id = value; }
        }
        #endregion
    }
}
