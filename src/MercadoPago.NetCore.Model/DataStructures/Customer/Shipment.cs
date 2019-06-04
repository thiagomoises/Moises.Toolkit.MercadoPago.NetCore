using System.Collections.Generic;

namespace MercadoPago.NetCore.Model.Resources.Dataclassures.Customer
{
    public class Shipment
    {
        #region Properties

        private bool success;
        private List<Error> errors;
        private string name;

        #endregion

        #region Accessors

        public bool Success
        {
            get { return success; }            
        }

        public List<Error> Errors
        {
            get { return errors; }            
        }

        public string Name
        {
            get { return name; }            
        }

        #endregion
    }
}
