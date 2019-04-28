using System.Collections.Generic;

namespace MercadoPago.NetCore.Model.DataStructures.Customer
{
    public struct Verification
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
