namespace MercadoPago.NetCore.Model.DataStructures.Search
{
    public class Paging
    {
        private int _offset;
        private int _limit;
        private int _total;

        public int Offset
        {
            get => this._offset;
            set { this._offset = value; }
        }

        public int Limit
        {
            get => this._limit;
            set { this._limit = value; }
        }

        public int Total
        {
            get => this._total;
            set { this._total = value; }
        }
    }
}
