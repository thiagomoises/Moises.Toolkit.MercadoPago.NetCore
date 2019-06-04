using System;

namespace MercadoPago.NetCore.Model.Resources.Dataclassures.Auth
{
    public class Ticket
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public bool LiveMode { get; set; }
        public int UserId { get; set; }
        public string TokenType { get; set; }
        public int ExpiresIn { get; set; }
        public string Scope { get; set; }
        
        private DateTime CreationDate { get; set; }

        public bool IsExpired => CreationDate.AddMilliseconds(ExpiresIn) > DateTime.Now;

        public Ticket()
        {
            CreationDate = DateTime.Now;
        }
    }
}
