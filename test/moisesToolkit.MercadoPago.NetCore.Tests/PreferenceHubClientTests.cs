using MercadoPago.NetCore.Model.Resources;
using MercadoPago.NetCore.Model.Resources.Dataclassures.Auth;
using MercadoPago.NetCore.Model.Resources.Dataclassures.Preference;
using moisesToolkit.MercadoPago.NetCore.HubClients;
using moisesToolkit.MercadoPago.NetCore.HubClients.Abstracts;
using moisesToolkit.MercadoPago.NetCore.Tests.Helpers;
using Moq;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Extensions;

namespace moisesToolkit.MercadoPago.NetCore.Tests
{
    [TestFixture]
    public class PreferenceHubClientTests
    {
        private PreferenceHubClient _PreferenceHubClient { get; set; }
        private string CustomerId { get; set; }

        [SetUp]
        public void Setup()
        {
            Mock<ITokenHubClient> tokenHubClient = new Mock<ITokenHubClient>();


            var customerHub = new CustomerHubClientTests();
            customerHub.Setup();
            if (customerHub.CustomerHubClient.SearchAsync(null).TryExecute(out var customers))
                CustomerId = customers.Results.Select(x => x.Id).FirstOrDefault();

            tokenHubClient.Setup(x => x.GetTicketAsync())
                .Returns(Task.FromResult(new Ticket() { AccessToken = "TEST-8600607042428103-060407-f91bbb3d5d0029bc342657a83aa08ee5-397002962" }));
            _PreferenceHubClient = new PreferenceHubClient(TicketHelperTest.GetHttpClient(), TicketHelperTest.GetMPOptions(), tokenHubClient.Object);
        }

        [TearDown]
        public void Cleanup()
        {
            _PreferenceHubClient = null;
        }
        /*
        [Test]
        public async Task SaveAsync_Test()
        {
            var Preference = new Preference()
            {
                CustomerId = CustomerId,
                ExpirationMonth = 9,
                ExpirationYear = 2022,
                FirstSixDigits = "123456",
                LastFourDigits = "7890",
                SecurityCode = new SecurityCode() { PreferenceLocation = "back", Length = 3 },
                PreferenceHolder = new PreferenceHolder { Name = "Thiago Moises" },
                DateCreated = DateTime.Now
            };
            var result = await _PreferenceHubClient.SaveAsync(Preference);

            bool firstCondition = (!string.IsNullOrEmpty(result?.Id) && Preference.FirstSixDigits.Equals(result?.FirstSixDigits) && _PreferenceHubClient.IsValid());
            bool secondCondition = _PreferenceHubClient.Notifications.Any(x => x.Message.Equals("the Preference already exist"));

            Assert.IsTrue(firstCondition || secondCondition);
        }
        */
        [Test]
        public async Task FindAsync_Test_Null()
        {
            var result = await _PreferenceHubClient.FindAsync(null);
            Assert.IsTrue(_PreferenceHubClient.IsInvalid());
        }

        [Test]
        public async Task FindAsync_Test_Empty()
        {
            var result = await _PreferenceHubClient.FindAsync( "");
            Assert.IsTrue(_PreferenceHubClient.IsInvalid());
        }

        [Test]
        public async Task SaveAsync_Test_Null()
        {
            var result = await _PreferenceHubClient.SaveAsync(null);
            Assert.IsTrue(_PreferenceHubClient.IsInvalid());
        }

        [Test]
        public async Task UpdateAsync_Test()
        {
            var result = await _PreferenceHubClient.UpdateAsync(null);
            Assert.IsTrue(_PreferenceHubClient.IsInvalid());
        }
        
    }
}
