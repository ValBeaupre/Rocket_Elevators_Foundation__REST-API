using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Rocket.Models;

namespace Rocket.Controllers {
    [Route ("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase {
        private readonly valerieContext _context;
        public CustomersController (valerieContext context) {
            _context = context;
        }


        // GET api/customers/all : to get the full customers list
        [HttpGet ("all")]
        public ActionResult<List<Customers>> GetAll () {
            return _context.Customers.ToList ();
        }
    }
}