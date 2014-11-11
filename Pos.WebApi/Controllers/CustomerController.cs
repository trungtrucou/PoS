using Pos.Application.Implementations;
using Pos.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Pos.WebApi.Controllers
{
    [RoutePrefix("Customers")]
    public class CustomerController : ApiController
    {
        private readonly ICustomerQueryService _customerQueryService;
        public CustomerController()
        {
            _customerQueryService = new CustomerQueryService();
        }
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetCustomers()
        {
            var result = _customerQueryService.GetCustomers();
            return Ok(result.ToList());
        }
    }
}
