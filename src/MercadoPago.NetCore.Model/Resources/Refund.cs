using System;
namespace MercadoPago.NetCore.Model
{
    public class Refund
    {
        #region Properties
        private decimal? _id;
        private decimal? _amount;
        private decimal? _payment_id;
        private DateTime? _date_created;
        private String _errors;

        #endregion

        #region Accessors

        public void manualSetPaymentId(decimal id){
            this.PaymentId = id;
        }

        public decimal? Id
        {
            get
            {
                return _id;
            }

            private set
            {
                _id = value;
            }
        }

        public decimal? Amount
        {
            get
            {
                return _amount;
            }

            set
            {
                _amount = value;
            }
        }

        public decimal? PaymentId
        {
            get
            {
                return _payment_id;
            }

            private set
            {
                _payment_id = value;
            }
        }

        public DateTime? DateCreated
        {
            get
            {
                return _date_created;
            }

            private set
            {
                _date_created = value;
            }
        }

        public String Errors
        {
            get
            {
                return _errors;
            }

            set
            {
                _errors = value;
            }
        }
        #endregion


    }
}
