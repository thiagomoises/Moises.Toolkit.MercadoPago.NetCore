using System.Collections.Generic;

namespace MercadoPago.NetCore.Model.Resources.Dataclassures.Customer
{
    public class Verification
    {
        #region Properties

        private List<Shipment> shipments;

        #endregion

        #region Accessors

        public List<Shipment> Shipments
        {
            get { return shipments; }
        }

        #endregion
    }
}
