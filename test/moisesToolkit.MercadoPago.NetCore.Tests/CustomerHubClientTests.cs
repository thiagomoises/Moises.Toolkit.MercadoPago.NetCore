using MercadoPago.NetCore.Model.Resources;
using MercadoPago.NetCore.Model.Resources.Dataclassures.Auth;
using moisesToolkit.MercadoPago.NetCore.HubClients;
using moisesToolkit.MercadoPago.NetCore.HubClients.Abstracts;
using moisesToolkit.MercadoPago.NetCore.Tests.Helpers;
using Moq;
using NUnit.Framework;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace moisesToolkit.MercadoPago.NetCore.Tests
{
    [TestFixture]
    public class CustomerHubClientTests
    {
        public CustomerHubClient CustomerHubClient { get; private set; }

        [SetUp]
        public void Setup()
        {
            Mock<ITokenHubClient> tokenHubClient = new Mock<ITokenHubClient>();

            Mock<IHttpClientFactory> _httpClientFactory = new Mock<IHttpClientFactory>();

            _httpClientFactory.Setup(x => x.CreateClient(It.IsAny<string>()))
                .Returns(TicketHelperTest.GetHttpClient());

            tokenHubClient.Setup(x => x.GetTicketAsync())
                .Returns(Task.FromResult(new Ticket() { AccessToken = "TEST-8600607042428103-060407-f91bbb3d5d0029bc342657a83aa08ee5-397002962" }));
            CustomerHubClient = new CustomerHubClient(_httpClientFactory.Object, TicketHelperTest.GetMPOptions(), tokenHubClient.Object);
        }

        [TearDown]
        public void Cleanup()
        {
            CustomerHubClient = null;
        }

        [Test]
        public async Task SaveAsync_Test()
        {
            var customer = new Customer()
            {
                FirstName = "Thiago Moises",
                Email = "email@email.com.br",
                LastName = "Moises",
            };
            var result = await CustomerHubClient.SaveAsync(customer);

            bool firstCondition = (!string.IsNullOrEmpty(result?.Id) && customer.LastName.Equals(result?.LastName) && CustomerHubClient.IsValid());
            bool secondCondition = CustomerHubClient.Notifications.Any(x => x.Message.Equals("the customer already exist"));

            Assert.IsTrue(firstCondition || secondCondition);
        }

        [Test]
        public async Task FindAsync_Test_Null()
        {
            var result = await CustomerHubClient.FindAsync(null);
            Assert.IsTrue(CustomerHubClient.IsInvalid());
        }

        [Test]
        public async Task FindAsync_Test_Empty()
        {
            var result = await CustomerHubClient.FindAsync(null);
            Assert.IsTrue(CustomerHubClient.IsInvalid());
        }

        [Test]
        public async Task SearchAsync_Test_Null()
        {
            var result = await CustomerHubClient.SearchAsync(null);
            Assert.IsTrue(CustomerHubClient.IsValid());
        }

        [Test]
        public async Task SearchAsync_Test_Empty()
        {
            var result = await CustomerHubClient.SearchAsync(new System.Collections.Generic.Dictionary<string, string>());
            Assert.IsTrue(CustomerHubClient.IsValid());
        }

        [Test]
        public async Task SaveAsync_Test_Null()
        {
            var result = await CustomerHubClient.SaveAsync(null);
            Assert.IsTrue(CustomerHubClient.IsInvalid());
        }

        [Test]
        public async Task UpdateAsync_Test()
        {
            var result = await CustomerHubClient.UpdateAsync(null);
            Assert.IsTrue(CustomerHubClient.IsInvalid());
        }

        [Test]
        public async Task DeleteAsync_Test()
        {
            var result = await CustomerHubClient.DeleteAsync(null);
            Assert.IsTrue(CustomerHubClient.IsInvalid());
        }

    }
}
