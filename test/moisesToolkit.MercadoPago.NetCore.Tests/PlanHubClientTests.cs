using MercadoPago.NetCore.Model.Resources.Dataclassures.Auth;
using moisesToolkit.MercadoPago.NetCore.HubClients;
using moisesToolkit.MercadoPago.NetCore.HubClients.Abstracts;
using moisesToolkit.MercadoPago.NetCore.Tests.Helpers;
using Moq;
using NUnit.Framework;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading.Tasks.Extensions;

namespace moisesToolkit.MercadoPago.NetCore.Tests
{
    [TestFixture]
    public class PlanHubClientTests
    {
        private PlanHubClient _PlanHubClient { get; set; }
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
            _PlanHubClient = new PlanHubClient(_httpClientFactory.Object, TicketHelperTest.GetMPOptions(), tokenHubClient.Object);
        }

        [TearDown]
        public void Cleanup()
        {
            _PlanHubClient = null;
        }
        /*
        [Test]
        public async Task SaveAsync_Test()
        {
            var Plan = new Plan()
            {
                CustomerId = CustomerId,
                ExpirationMonth = 9,
                ExpirationYear = 2022,
                FirstSixDigits = "123456",
                LastFourDigits = "7890",
                SecurityCode = new SecurityCode() { PlanLocation = "back", Length = 3 },
                PlanHolder = new PlanHolder { Name = "Thiago Moises" },
                DateCreated = DateTime.Now
            };
            var result = await _PlanHubClient.SaveAsync(Plan);

            bool firstCondition = (!string.IsNullOrEmpty(result?.Id) && Plan.FirstSixDigits.Equals(result?.FirstSixDigits) && _PlanHubClient.IsValid());
            bool secondCondition = _PlanHubClient.Notifications.Any(x => x.Message.Equals("the Plan already exist"));

            Assert.IsTrue(firstCondition || secondCondition);
        }
        */
        [Test]
        public async Task FindAsync_Test_Null()
        {
            var result = await _PlanHubClient.FindAsync(null);
            Assert.IsTrue(_PlanHubClient.IsInvalid());
        }

        [Test]
        public async Task FindAsync_Test_Empty()
        {
            var result = await _PlanHubClient.FindAsync("");
            Assert.IsTrue(_PlanHubClient.IsInvalid());
        }

        [Test]
        public async Task SaveAsync_Test_Null()
        {
            var result = await _PlanHubClient.SaveAsync(null);
            Assert.IsTrue(_PlanHubClient.IsInvalid());
        }

        [Test]
        public async Task UpdateAsync_Test()
        {
            var result = await _PlanHubClient.UpdateAsync(null);
            Assert.IsTrue(_PlanHubClient.IsInvalid());
        }

    }
}
