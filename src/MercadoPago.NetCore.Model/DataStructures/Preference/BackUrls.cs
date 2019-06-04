namespace MercadoPago.NetCore.Model.Resources.Dataclassures.Preference
{
    public class BackUrls
    {
        #region Properties
        
        private string _success; 
        
        private string _pending; 
        
        private string _failure; 
        #endregion

        #region Accessors 
        ///<summary>Approved payment URL</summary>
        public string Success 
        { 
            get { return  _success; } 
            set {  _success = value; } 
        }
        ///<summary>Pending payment URLL</summary>
        public string Pending 
        { 
            get { return  _pending; } 
            set {  _pending = value; } 
        }
        ///<summary>Canceled payment URL</summary>
        public string Failure 
        { 
            get { return  _failure; } 
            set {  _failure = value; } 
        } 
        #endregion

    }
}
