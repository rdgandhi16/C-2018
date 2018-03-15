using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C4u.Library.Interface;
using C4u.Library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace C4uServices.Controllers
{
    [Produces("application/json")]
    [Route("api/CustomerApi")]
    public class CustomerApiController : Controller
    {
        private IRepository<Customer> _customerrepo;

        public CustomerApiController(IRepository<Customer> customerrepo)
        {
            _customerrepo = customerrepo;
        }
        [HttpGet]
        public IActionResult GetAllCustomer()
        {
            return Ok(_customerrepo.GetAll());
        }
    }
}