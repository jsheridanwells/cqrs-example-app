using System.Threading.Tasks;
using Customer.Api.Models.Sqlite;
using Microsoft.AspNetCore.Mvc;

namespace Customer.Api.Controllers
{
    [ApiController]
    [Route("api/[controller")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerDbRepository _repo;

        public CustomersController(ICustomerDbRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            return Ok();
        }

        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetById(long customerId)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CustomerRecord customer)
        {
            return Ok();
        }

        [HttpPost("{customerId}")]
        public async Task<IActionResult> Update(long id, CustomerRecord customer)
        {
            return Ok();
        }

        [HttpDelete("{customerId}")]
        public async Task<IActionResult> Delete(long customerId)
        {
            return Ok();
        }
    }
}