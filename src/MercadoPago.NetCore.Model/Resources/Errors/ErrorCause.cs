using System;
using System.Collections.Generic;
using System.Text;

namespace MercadoPago.NetCore.Model.Resources.Errors
{
    public class ErrorCause
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
