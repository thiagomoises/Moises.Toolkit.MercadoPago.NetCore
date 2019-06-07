namespace MercadoPago.NetCore.Model.Resources.Dataclassures.Card
{
    public class Identification
    {
        #region Properties 
        private string _number;
        private string _subtype;
        private string _type; 
        #endregion

        #region Accessors
        /// <summary>
        /// Identification number
        /// </summary>
        public string Number
        {
            get { return _number;  }
            set { _number = value; }
        }
        /// <summary>
        /// Identification subtype
        /// </summary>
        public string Subtype { 
            get { return _subtype;  }
            set { _subtype = value; } 
        }
        /// <summary>
        /// Identification type
        /// </summary>
        public string Type 
        { 
            get { return _type; } 
            set { _type = value; }
        }
        #endregion
    }
}
