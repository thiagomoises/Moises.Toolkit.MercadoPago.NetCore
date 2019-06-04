using moisesToolkit.MercadoPago.NetCore.HubClients;
using moisesToolkit.MercadoPago.NetCore.Tests.Helpers;
using Moq;
using NUnit.Framework;
using System.Net.Http;
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
            Mock<IHttpClientFactory> _httpClientFactory = new Mock<IHttpClientFactory>();

            _httpClientFactory.Setup(x => x.CreateClient(It.IsAny<string>()))
                .Returns(TicketHelperTest.GetHttpClient());

            _tokenHubClient = new TokenHubClient(_httpClientFactory.Object, TicketHelperTest.GetMPOptions());
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
