﻿namespace MercadoPago.NetCore.Model.Resources.Dataclassures.Preference
{
    public class DifferentialPricing
    {
        #region Properties 
        private int _id; 
        #endregion

        #region Accessors
        /// <summary>
        /// Differential pricing ID
        /// </summary>
        public int Id
        {
            get{ return this._id; }
            set{ this._id = value; }
        } 
        #endregion
    }
}
