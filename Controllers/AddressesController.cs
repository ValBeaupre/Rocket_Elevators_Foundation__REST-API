using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Rocket.Models;

namespace Rocket.Controllers {
    [Route ("api/addresses")]
    [ApiController]
    public class AddressesController : ControllerBase {
        private readonly valerieContext _context;
        public AddressesController (valerieContext context) {
            _context = context;
        }


       // GET api/addresses/all : to get the full addresses list
       [HttpGet ("all")]
       public ActionResult<List<Addresses>> GetAll() {
           return _context.Addresses.ToList();
       }


       // GET api/addresses/cities : to get the building's cities list
       [HttpGet ("cities")]
       public ActionResult<List<string>> GetCities() {
           var cities = _context.Addresses.Where(a => _context.Buildings.Select(b => b.AddressId).Contains(a.Id)).Select(c => c.City).Distinct();
           return cities.ToList();
       }
    }
}