namespace MercadoPago.NetCore.Model.Resources.Dataclassures.Preference
{
    public class Identification
    {
        #region Properties 
        
        private string _type;
        
        private string _number;
        #endregion

        #region Accessors 
        /// <summary>
        /// Identification type
        /// </summary>
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        /// <summary>
        /// Identification number
        /// </summary>
        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }
        #endregion
    }
}
