using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Rocket.Models;

namespace Rocket.Controllers {
    [Route ("api/quotes")]
    [ApiController]
    public class QuotesController : ControllerBase {
        private readonly valerieContext _context;
        public QuotesController (valerieContext context) {
            _context = context;
        }


        // GET api/quotes/all : to get the full quotes list
        [HttpGet ("all")]
        public ActionResult<List<Quotes>> GetAll () {
            return _context.Quotes.ToList ();
        }
    }
}