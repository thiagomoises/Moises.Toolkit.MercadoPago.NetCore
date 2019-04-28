﻿using MercadoPago.NetCore.Model.Enum;

namespace MercadoPago.NetCore.Model.DataStructures.Preference
{
    public struct Item
    {
        #region Properties 
        
        private string _id;
        
        private string _title;
        
        private string _description;
        
        private string _pictureU_url;
        
        private int? _category_id;
        private int? _quantity;
        
        private CurrencyId _currency_id;
        private decimal unit_price; 
        #endregion

        #region Accessors 
        /// <summary>
        /// Item ID
        /// </summary>
        public string Id
        { 
            get { return  _id; } 
            set {  _id = value; }
        }
        /// <summary>
        /// Item title. It will be displayed in the payment process.
        /// </summary>
        public string Title
        {
            get { return  _title; } 
            set {  _title = value; }
        }
        /// <summary>
        /// Item description
        /// </summary>
        public string Description
        {
            get { return  _description; } 
            set {  _description = value; } 
        }
        /// <summary>
        /// Item image URL
        /// </summary>
        public string PictureUrl
        {
            get { return  _pictureU_url; }
            set {  _pictureU_url = value; }
        }
        /// <summary>
        /// Item category ID
        /// </summary>
        public int? CategoryId
        {
            get { return  _category_id; }
            set {  _category_id = value; }
        }
        /// <summary>
        /// Item quantity
        /// </summary>
        public int? Quantity
        {
            get { return  _quantity; }
            set {  _quantity = value; }
        }
        /// <summary>
        /// Currency ID. ISO_4217 code
        /// </summary>
        public CurrencyId CurrencyId
        {
            get { return  _currency_id; } 
            set {  _currency_id = value; }
        }
        /// <summary>
        /// Unit price
        /// </summary>
        public decimal UnitPrice
        {
            get { return  unit_price; } 
            set {  unit_price = value; }
        } 
        #endregion
    }
}
