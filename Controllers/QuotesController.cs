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
        private readonly val_interventionsContext _context;
        public QuotesController (val_interventionsContext context) {
            _context = context;
        }


        // GET api/quotes/all : to get the full quotes list
        [HttpGet ("all")]
        public ActionResult<List<Quotes>> GetAll () {
            return _context.Quotes.ToList ();
        }


        // // GET api/quotes/pending : to get the quote list with the "Pending" status and NO Starting Time
        // [HttpGet ("pending")]
        // public ActionResult<List<Interventions>> GetPending () {
        //     var list = _context.Interventions.ToList ();
        //     if (list == null) {
        //         return NotFound ("Not Found");
        //     }

        //     List<Interventions> list_pending = new List<Interventions> ();

        //     foreach (var i in list) { 

        //         if ((i.Status == "Pending") && (i.InterventionStartTime == null)) {
        //             list_pending.Add (i);
        //         }
        //     }
        //     return list_pending;
        // }
    }
}