using moisesToolkit.MercadoPago.NetCore.HubClients;
using moisesToolkit.MercadoPago.NetCore.Tests.Helpers;
using NUnit.Framework;
using System.Threading.Tasks;

namespace moisesToolkit.MercadoPago.NetCore.Tests
{
    [TestFixture]
    public class TokenHubClientTests
    {
        private TokenHubClient _tokenHubClient { get; set; }

        [SetUp]
        public void Setup()
        {
            _tokenHubClient = new TokenHubClient(TicketHelperTest.GetHttpClient(), TicketHelperTest.GetMPOptions());
        }

        [TearDown]
        public void Cleanup()
        {
            _tokenHubClient = null;
        }

        [Test]
        public async Task GetAccessTokenAsync_Test()
        {
            var result = await _tokenHubClient.GetTicketAsync();
            Assert.IsTrue(!string.IsNullOrEmpty(result.AccessToken));
        }

    }
}
