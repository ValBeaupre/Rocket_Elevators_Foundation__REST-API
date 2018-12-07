using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rocket.Models;

namespace Rocket.Controllers {
    [Route ("api/leads")]
    [ApiController]
    public class LeadsController : ControllerBase {
        private readonly valerieContext _context;
        public LeadsController (valerieContext context) {
            _context = context;
        }


        // GET api/leads/all : to get the full lead list
        [HttpGet ("all")]
        public ActionResult<List<Leads>> GetAll () {
            return _context.Leads.ToList ();
        }


        // GET api/leads/list : to get the last 30 days leads
        [HttpGet ("list")]
        public ActionResult<List<Leads>> GetList () {
            var listl = _context.Leads.Include (le => le.Customers);

            if (listl == null) {
                return NotFound ("Not Found");
            }

            List<Leads> list_lead = new List<Leads> ();
            DateTime currentDate = DateTime.Now.AddDays (-30);
            foreach (var l in listl) {
                if (l.CreatedAt >= currentDate) {
                    if (l.Customers.ToList ().Count == 0) {
                        list_lead.Add (l);
                    }
                }
            }
            return list_lead;
        }
    }
}