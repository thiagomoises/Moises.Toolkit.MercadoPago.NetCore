using Microsoft.AspNetCore.Mvc;
using Moises.Toolkit.MercadoPago.NetCore.HubClients.Abstracts;
using System.Threading.Tasks;

namespace Moises.Toolkit.MercadoPago.NetCore.Sample.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerHubClient _customerHubClient;

        public CustomerController(ICustomerHubClient customerHubClient)
        {
            _customerHubClient = customerHubClient;
        }

        // GET api/values
        [HttpGet, Route("api/costumer/Search")]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _customerHubClient.SearchAsync(null);
            return Ok(result);
        }
    }
}
