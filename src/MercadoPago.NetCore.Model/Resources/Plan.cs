using MercadoPago.NetCore.Model.Resources.Dataclassures.Plan;
using System;

namespace MercadoPago.NetCore.Model.Resources
{
    public class Plan
    {
        #region Properties 
        private string id;
        private float application_fee;
        private string status;
        private string description;
        private string external_reference;
        private DateTime date_created;
        private DateTime last_modified;
        private AutoRecurring auto_recurring;
        private Boolean live_mode;
        private float setup_fee;
        private string metadata; 
        #endregion


        #region Accessors 
        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public float ApplicationFee
        {
            get
            {
                return application_fee;
            }

            set
            {
                application_fee = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public string ExternalReference
        {
            get
            {
                return external_reference;
            }

            set
            {
                external_reference = value;
            }
        }

        public DateTime DateCreated
        {
            get
            {
                return date_created;
            }

            set
            {
                date_created = value;
            }
        }

        public DateTime LastModified
        {
            get
            {
                return last_modified;
            }

            set
            {
                last_modified = value;
            }
        }

        public AutoRecurring AutoRecurring
        {
            get
            {
                return auto_recurring;
            }

            set
            {
                auto_recurring = value;
            }
        }

        public bool LiveMode
        {
            get
            {
                return live_mode;
            }

            set
            {
                live_mode = value;
            }
        }

        public float SetupFee
        {
            get
            {
                return setup_fee;
            }

            set
            {
                setup_fee = value;
            }
        }

        public string Metadata
        {
            get
            {
                return metadata;
            }

            set
            {
                metadata = value;
            }
        }
        #endregion
    }
}
