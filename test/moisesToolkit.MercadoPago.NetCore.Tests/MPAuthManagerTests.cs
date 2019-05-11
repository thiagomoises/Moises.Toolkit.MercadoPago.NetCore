using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace moisesToolkit.MercadoPago.NetCore.Tests
{
    [TestFixture]
    public class MPAuthManagerTests
    {
        private MPAuthManager _mPAuthManager { get; set; }

        public MPAuthManagerTests() { }


        [SetUp]
        public void Setup()
        {
            Mock<IHttpClientFactory> httpClientFactory = new Mock<IHttpClientFactory>();

            httpClientFactory.Setup(x => x.CreateClient(It.IsAny<string>()))
                .Returns(new HttpClient() { BaseAddress = new Uri("https://api.mercadopago.com") });

            _mPAuthManager = new MPAuthManager(httpClientFactory.Object, new MPOptions() { ClientId = "701342797733779", ClientSecret = "uyjunhCODZnR7LNPykouD076Eig74hF8" });
        }

        [TearDown]
        public void Cleanup()
        {
            _mPAuthManager = null;
        }

        [Test]
        public async Task GetAccessTokenAsync_Test()
        {
            var ticket = await _mPAuthManager.GetAccessTokenAsync();
            Assert.IsTrue(ticket != null && !string.IsNullOrEmpty(ticket.AccessToken));
        }

    }
}
