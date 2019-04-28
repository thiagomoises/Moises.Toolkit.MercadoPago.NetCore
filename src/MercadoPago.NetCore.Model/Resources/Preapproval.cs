using MercadoPago.NetCore.Model.DataStructures.Preapproval;
using System;
using System.Collections.Generic;

namespace MercadoPago.NetCore.Model
{
    public class Preapproval
    {
        #region Properties

        private string _payer_email;
        private string _back_url;
        private string _id;
        private string _init_point;
        private string _sandbox_init_point;
        private string _external_reference;
        private string _reason;
        private AutoRecurring? _auto_recurring;

        #endregion

        #region Accesors

        /// <summary>
        ///  identifier
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
        ///  Buy reason
        /// </summary>
        public string Reason
        {
            get
            {
                return _reason;
            }

            set
            {
                _reason = value;
            }
        }

        /// <summary>
        ///  Payer Email
        /// </summary>
        public string PayerEmail
        {
            get
            {
                return _payer_email;
            }

            set
            {
                _payer_email = value;
            }
        }

        /// <summary>
        ///  Return  URL
        /// </summary>
        public string BackUrl
        {
            get
            {
                return _back_url;
            }

            set
            {
                _back_url = value;
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
        /// Auro Recurring Information
        /// </summary>
        public AutoRecurring? AutoRecurring
        {
            get
            {
                return _auto_recurring;
            }

            set
            {
                _auto_recurring = value;
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

        #endregion



    }
}
