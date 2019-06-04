namespace MercadoPago.NetCore.Model.Resources.Dataclassures.PaymentMethod
{
    public class Settings
    {
        private Bin _bin;
        private CardNumber _card_number;
        private SecurityCode _security_code;

        public Bin Bin
        {
            get
            {
                return _bin;
            }

            set
            {
                _bin = value;
            }
        }

        public CardNumber CardNumber
        {
            get
            {
                return _card_number;
            }

            set
            {
                _card_number = value;
            }
        }

        public SecurityCode SecurityCode
        {
            get
            {
                return _security_code;
            }

            set
            {
                _security_code = value;
            }
        }
    }
}
