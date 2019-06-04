using System.Collections.Generic;

namespace MercadoPago.NetCore.Model.Resources.Errors
{
    public class ErrorResult
    {
        public string Message { get; set; }
        public string Error { get; set; }
        public int Status { get; set; }
        public IEnumerable<ErrorCause> Causes { get; set; }
    }
}
