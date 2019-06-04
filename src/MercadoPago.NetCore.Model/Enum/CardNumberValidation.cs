namespace MercadoPago.NetCore.Model.Resources.Enum
{
    public enum CardNumberValidation
    {
        /// <summary> The card number should validate Luhn's algorithm </summary>
        standard,
        /// <summary> There is no algorithm to validate the checksum </summary>
        none
    }
}
