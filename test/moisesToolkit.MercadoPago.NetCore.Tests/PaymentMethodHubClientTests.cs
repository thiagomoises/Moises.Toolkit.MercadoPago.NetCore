using MercadoPago.NetCore.Model.Resources;
using MercadoPago.NetCore.Model.Resources.Dataclassures.Auth;
using MercadoPago.NetCore.Model.Resources.Dataclassures.PaymentMethod;
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
    public class PaymentMethodHubClientTests
    {
        private PaymentMethodHubClient _PaymentMethodHubClient { get; set; }
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
            _PaymentMethodHubClient = new PaymentMethodHubClient(TicketHelperTest.GetHttpClient(), TicketHelperTest.GetMPOptions(), tokenHubClient.Object);
        }

        [TearDown]
        public void Cleanup()
        {
            _PaymentMethodHubClient = null;
        }
        /*
        [Test]
        public async Task SaveAsync_Test()
        {
            var PaymentMethod = new PaymentMethod()
            {
                CustomerId = CustomerId,
                ExpirationMonth = 9,
                ExpirationYear = 2022,
                FirstSixDigits = "123456",
                LastFourDigits = "7890",
                SecurityCode = new SecurityCode() { PaymentMethodLocation = "back", Length = 3 },
                PaymentMethodHolder = new PaymentMethodHolder { Name = "Thiago Moises" },
                DateCreated = DateTime.Now
            };
            var result = await _PaymentMethodHubClient.SaveAsync(PaymentMethod);

            bool firstCondition = (!string.IsNullOrEmpty(result?.Id) && PaymentMethod.FirstSixDigits.Equals(result?.FirstSixDigits) && _PaymentMethodHubClient.IsValid());
            bool secondCondition = _PaymentMethodHubClient.Notifications.Any(x => x.Message.Equals("the PaymentMethod already exist"));

            Assert.IsTrue(firstCondition || secondCondition);
        }
        */

        [Test]
        public async Task GetPaymentMethods_Test()
        {
            var result = await _PaymentMethodHubClient.GetPaymentMethods();
            Assert.IsTrue(_PaymentMethodHubClient.IsValid());
        }

    }
}
