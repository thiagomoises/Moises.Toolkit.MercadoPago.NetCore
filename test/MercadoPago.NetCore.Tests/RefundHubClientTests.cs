using MercadoPago.NetCore.Model.Resources.Dataclassures.Auth;
using Moises.Toolkit.MercadoPago.NetCore.HubClients;
using Moises.Toolkit.MercadoPago.NetCore.HubClients.Abstracts;
using Moises.Toolkit.MercadoPago.NetCore.Tests.Helpers;
using Moq;
using NUnit.Framework;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading.Tasks.Extensions;

namespace Moises.Toolkit.MercadoPago.NetCore.Tests
{
    [TestFixture]
    public class RefundHubClientTests
    {
        private RefundHubClient _RefundHubClient { get; set; }
        private string CustomerId { get; set; }

        [SetUp]
        public void Setup()
        {
            Mock<ITokenHubClient> tokenHubClient = new Mock<ITokenHubClient>();

            Mock<IHttpClientFactory> _httpClientFactory = new Mock<IHttpClientFactory>();

            _httpClientFactory.Setup(x => x.CreateClient(It.IsAny<string>()))
                .Returns(TicketHelperTest.GetHttpClient());

            var customerHub = new CustomerHubClientTests();
            customerHub.Setup();
            if (customerHub.CustomerHubClient.SearchAsync(null).TryExecute(out var customers))
                CustomerId = customers.Results.Select(x => x.Id).FirstOrDefault();

            tokenHubClient.Setup(x => x.GetTicketAsync())
                .Returns(Task.FromResult(new Ticket() { AccessToken = "TEST-8600607042428103-060407-f91bbb3d5d0029bc342657a83aa08ee5-397002962" }));
            _RefundHubClient = new RefundHubClient(_httpClientFactory.Object, TicketHelperTest.GetMPOptions(), tokenHubClient.Object);
        }

        [TearDown]
        public void Cleanup()
        {
            _RefundHubClient = null;
        }
        /*
        [Test]
        public async Task SaveAsync_Test()
        {
            var Refund = new Refund()
            {
                CustomerId = CustomerId,
                ExpirationMonth = 9,
                ExpirationYear = 2022,
                FirstSixDigits = "123456",
                LastFourDigits = "7890",
                SecurityCode = new SecurityCode() { RefundLocation = "back", Length = 3 },
                RefundHolder = new RefundHolder { Name = "Thiago Moises" },
                DateCreated = DateTime.Now
            };
            var result = await _RefundHubClient.SaveAsync(Refund);

            bool firstCondition = (!string.IsNullOrEmpty(result?.Id) && Refund.FirstSixDigits.Equals(result?.FirstSixDigits) && _RefundHubClient.IsValid());
            bool secondCondition = _RefundHubClient.Notifications.Any(x => x.Message.Equals("the Refund already exist"));

            Assert.IsTrue(firstCondition || secondCondition);
        }
        */
        [Test]
        public async Task SaveAsync_Test_Null()
        {
            var result = await _RefundHubClient.SaveAsync(null);
            Assert.IsTrue(_RefundHubClient.IsInvalid());
        }

    }
}
