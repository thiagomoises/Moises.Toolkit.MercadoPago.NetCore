using System;

namespace moisesToolkit.MercadoPago.NetCore
{
    public class MPOptions
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string SandboxAccessToken { get; private set; }
        public bool UseSandbox { get; private set; }
        public void UseSandboxAccessToken(string accessToken)
        {
            if (string.IsNullOrEmpty(accessToken))
            {
                throw new ArgumentException("message", nameof(accessToken));
            }
            SandboxAccessToken = accessToken;
            UseSandbox = true;
        }
    }
}
