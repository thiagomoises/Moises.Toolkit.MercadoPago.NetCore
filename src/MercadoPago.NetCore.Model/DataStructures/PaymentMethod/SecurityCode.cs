using MercadoPago.NetCore.Model.Resources.Enum;

namespace MercadoPago.NetCore.Model.Resources.Dataclassures.PaymentMethod
{
    public class SecurityCode
    {
        private SecurityCodeMode _mode;
        private int _length;
        private SecurityCodeCardLocation _card_location;

        public SecurityCodeMode Mode
        {
            get
            {
                return _mode;
            }

            set
            {
                _mode = value;
            }
        }

        public int Length
        {
            get
            {
                return _length;
            }

            set
            {
                _length = value;
            }
        }

        public SecurityCodeCardLocation CardLocation
        {
            get
            {
                return _card_location;
            }

            set
            {
                _card_location = value;
            }
        }
    }
}
