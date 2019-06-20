using MercadoPago.NetCore.Model.Resources.Dataclassures.Payment;
using MercadoPago.NetCore.Model.Resources.Enum;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace MercadoPago.NetCore.Request
{
    public class PaymentRequest
    {
        /// <summary>
        /// Identifies the buyer  
        /// </summary>
        public Payer Payer { get; set; }
        /// <summary>
        /// When set to true, the payment can only be approved or rejected. 
        /// Otherwise in_process status is added
        /// </summary>
        public bool BinaryMode { get; set; }
        /// <summary>
        /// Order identifier
        /// </summary>
        public Order Order { get; set; }
        /// <summary>
        /// ID given by the merchant in their system
        /// </summary>
        public string ExternalReference { get; set; }
        /// <summary>
        /// Payment reason or item title
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Valid JSON that can be attached to the payment to record additional attributes of the merchant
        /// </summary>
        public JObject Metadata { get; set; }
        /// <summary>
        /// ID of the currency used in the payment
        /// </summary>
        public CurrencyId CurrencyId { get; set; }
        /// <summary>
        /// Product cost
        /// </summary>
        public float TransactionAmount { get; set; }
        /// <summary>
        /// Amount of the coupon discount
        /// </summary>
        public float CouponAmount { get; set; }
        /// <summary>
        /// Discount campaign ID
        /// </summary>
        public int CampaignId { get; set; }
        /// <summary>
        /// Discount campaign with a specific code
        /// </summary>
        public string CouponCode { get; set; }
        /// <summary>
        /// Id of the scheme for the absorption of financing fee
        /// </summary>
        public int DifferentialPricingId { get; set; }
        /// <summary>
        /// Fee collected by a marketplace or MercadoPago Application
        /// </summary>
        public float ApplicationFee { get; set; }
        /// <summary>
        /// Gives more detailed information on the current state or rejection cause
        /// </summary>
        public bool Capture { get; set; }
        /// <summary>
        /// Gives more detailed information on the current state or rejection cause
        /// </summary>
        public string PaymentMethodId { get; set; }
        /// <summary>
        /// Payment method issuer
        /// </summary>
        public string IssuerId { get; set; }
        /// <summary>
        /// Card token ID
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// How will look the payment in the card bill (e.g.: MERCADOPAGO)
        /// </summary>
        public string StatementDescriptor { get; set; }
        /// <summary>
        /// Selected quantity of installments
        /// </summary>
        public int Installments { get; set; }
        /// <summary>
        /// URL where mercadopago will send notifications associated to changes in this payment
        /// </summary>
        public string NotificationUrl { get; set; }
        /// <summary>
        /// URL where mercadopago does the final redirect (only for bank transfers)
        /// </summary>
        public string CallbackUrl { get; set; }
        /// <summary>
        /// Data that could improve fraud analysis and conversion rates. 
        /// Try to send as much information as possible.
        /// </summary>
        public AdditionalInfo AdditionalInfo { get; set; }
    }
}
