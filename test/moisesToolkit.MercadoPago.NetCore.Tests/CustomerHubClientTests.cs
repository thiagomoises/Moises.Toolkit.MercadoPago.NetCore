using MercadoPago.NetCore.Model.Resources;
using MercadoPago.NetCore.Model.Resources.Dataclassures.Auth;
using MercadoPago.NetCore.Model.Resources.Dataclassures.Customer;
using moisesToolkit.MercadoPago.NetCore.HubClients;
using moisesToolkit.MercadoPago.NetCore.HubClients.Abstracts;
using moisesToolkit.MercadoPago.NetCore.Tests.Helpers;
using Moq;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace moisesToolkit.MercadoPago.NetCore.Tests
{
    [TestFixture]
    public class CustomerHubClientTests
    {
        private CustomerHubClient _customerHubClient { get; set; }

        [SetUp]
        public void Setup()
        {
            Mock<ITokenHubClient> tokenHubClient = new Mock<ITokenHubClient>();

            tokenHubClient.Setup(x => x.GetTicketAsync())
                .Returns(Task.FromResult(new Ticket() { AccessToken = "TEST-8600607042428103-060407-f91bbb3d5d0029bc342657a83aa08ee5-397002962" }));
            _customerHubClient = new CustomerHubClient(TicketHelperTest.GetHttpClient(), TicketHelperTest.GetMPOptions(), tokenHubClient.Object);
        }

        [TearDown]
        public void Cleanup()
        {
            _customerHubClient = null;
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
            var result = await _customerHubClient.SaveAsync(customer);

            bool firstCondition = (!string.IsNullOrEmpty(result?.Id) && customer.LastName.Equals(result?.LastName) && _customerHubClient.IsValid());
            bool secondCondition = _customerHubClient.Notifications.Any(x => x.Message.Equals("the customer already exist"));

            Assert.IsTrue(firstCondition || secondCondition);
        }

        [Test]
        public async Task FindAsync_Test_Null()
        {
            var result = await _customerHubClient.FindAsync(null);
            Assert.IsTrue(_customerHubClient.IsInvalid());
        }

        [Test]
        public async Task FindAsync_Test_Empty()
        {
            var result = await _customerHubClient.FindAsync(null);
            Assert.IsTrue(_customerHubClient.IsInvalid());
        }

        [Test]
        public async Task SearchAsync_Test_Null()
        {
            var result = await _customerHubClient.SearchAsync(null);
            Assert.IsTrue(_customerHubClient.IsValid());
        }

        [Test]
        public async Task SearchAsync_Test_Empty()
        {
            var result = await _customerHubClient.SearchAsync(new System.Collections.Generic.Dictionary<string, string>());
            Assert.IsTrue(_customerHubClient.IsValid());
        }

        [Test]
        public async Task SaveAsync_Test_Null()
        {
            var result = await _customerHubClient.SaveAsync(null);
            Assert.IsTrue(_customerHubClient.IsInvalid());
        }

        [Test]
        public async Task UpdateAsync_Test()
        {
            var result = await _customerHubClient.UpdateAsync(null);
            Assert.IsTrue(_customerHubClient.IsInvalid());
        }

        [Test]
        public async Task DeleteAsync_Test()
        {
            var result = await _customerHubClient.DeleteAsync(null);
            Assert.IsTrue(_customerHubClient.IsInvalid());
        }

    }
}
