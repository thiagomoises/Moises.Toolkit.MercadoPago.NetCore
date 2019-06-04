namespace MercadoPago.NetCore.Model.Resources.Dataclassures.Card
{
    public class Identification
    {
        #region Properties 
        private int _number;
        private string _subtype;
        private string _type; 
        #endregion

        #region Accessors
        /// <summary>
        /// Identification number
        /// </summary>
        public int Number
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
