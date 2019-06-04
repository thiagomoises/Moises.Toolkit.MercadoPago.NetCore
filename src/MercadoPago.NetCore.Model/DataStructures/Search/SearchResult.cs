using System;
using System.Collections.Generic;
using System.Text;

namespace MercadoPago.NetCore.Model.DataStructures.Search
{
    public class SearchResult<TResult> where TResult : class
    {
        private Paging _paging;
        private IEnumerable<TResult> _results;
        public Paging Paging
        {
            get => _paging; set { this._paging = value; }
        }
        public IEnumerable<TResult> Results { get => this._results; set { this._results = value; } }

    }
}
