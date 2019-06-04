﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MercadoPago.NetCore.Model.Resources.Enum
{
    public enum PaymentTypeId
    {
        ///<summary>Money in the MercadoPago account</summary>
        account_money,
        ///<summary>Printed ticket</summary>
        ticket,
        ///<summary>Wire transfer</summary>
        bank_transfer,
        ///<summary>Payment by ATM</summary>
        atm,
        ///<summary>Payment by credit card</summary>
        credit_card,
        ///<summary>Payment by debit card</summary>
        debit_card,
        ///<summary>Payment by prepaid card</summary>
        prepaid_card
    }
}
