using MercadoPago.NetCore.Model.Resources.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace MercadoPago.NetCore.Model.Resources.Dataclassures.Preapproval
{
    public class AutoRecurring
    {
        #region Properties 

        private int frequency;
        [JsonConverter(typeof(StringEnumConverter))]
        private FrequencyType frequency_type;
        private float transaction_amount;
        
        private CurrencyId currency_id;
        private DateTime start_date;
        private DateTime end_date;

        #endregion

        #region Accessors

        public FrequencyType FrequencyType
        {
            get
            {
                return frequency_type;
            }

            set
            {
                frequency_type = value;
            }
        }

        public int Frequency
        {
            get { return frequency; }
            set { frequency = value; }
        }

        public float TransactionAmount
        {
            get { return transaction_amount; }
            set { transaction_amount = value; }
        }

        public CurrencyId CurrencyId
        {
            get { return currency_id; }
            set { currency_id = value; }
        }

        public DateTime StartDate
        {
            get
            {
                return start_date;
            }

            set
            {
                start_date = value;
            }
        }


        public DateTime EndDate
        {
            get
            {
                return end_date;
            }

            set
            {
                end_date = value;
            }
        }

        #endregion
    }
}
