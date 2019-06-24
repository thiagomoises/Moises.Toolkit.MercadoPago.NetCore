using MercadoPago.NetCore.Model.Resources;
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
    public class CardHubClientTests
    {
        private CardsHubClient _CardHubClient { get; set; }
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
            if (customerHub.CustomerHubClient.SearchAsync(null).TryExecute(out var customers, 10000))
                CustomerId = customers.Results.Select(x => x.Id).FirstOrDefault();

            tokenHubClient.Setup(x => x.GetTicketAsync())
                .Returns(Task.FromResult(new Ticket() { AccessToken = "TEST-8600607042428103-060407-f91bbb3d5d0029bc342657a83aa08ee5-397002962" }));
            _CardHubClient = new CardsHubClient(_httpClientFactory.Object, TicketHelperTest.GetMPOptions(), tokenHubClient.Object);
        }

        [TearDown]
        public void Cleanup()
        {
            _CardHubClient = null;
        }
        /*
        [Test]
        public async Task SaveAsync_Test()
        {
            Card card = new Card()
            {
                Token = "9b2d63e00d66a8c721607214cedaecda",
                CustomerId = this.CustomerId
            };

            var result = await _CardHubClient.SaveAsync(card);

            bool firstCondition = (!string.IsNullOrEmpty(result?.Id) && card.FirstSixDigits.Equals(result?.FirstSixDigits) && _CardHubClient.IsValid());
            bool secondCondition = _CardHubClient.Notifications.Any(x => x.Message.Equals("the card already exist"));

            Assert.IsTrue(firstCondition || secondCondition);
        }
        */
        [Test]
        public async Task FindAsync_Test_Null()
        {
            var result = await _CardHubClient.FindAsync(null, null);
            Assert.IsTrue(_CardHubClient.IsInvalid());
        }

        [Test]
        public async Task FindAsync_Test_Empty()
        {
            var result = await _CardHubClient.FindAsync("", "");
            Assert.IsTrue(_CardHubClient.IsInvalid());
        }

        [Test]
        public async Task SaveAsync_Test_Null()
        {
            var result = await _CardHubClient.SaveAsync(null);
            Assert.IsTrue(_CardHubClient.IsInvalid());
        }

        [Test]
        public async Task UpdateAsync_Test()
        {
            var result = await _CardHubClient.UpdateAsync(null);
            Assert.IsTrue(_CardHubClient.IsInvalid());
        }

        [Test]
        public async Task DeleteAsync_Test()
        {
            var result = await _CardHubClient.DeleteAsync(null);
            Assert.IsTrue(_CardHubClient.IsInvalid());
        }

    }
}
