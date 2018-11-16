using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Rocket.Models;

namespace Rocket.Controllers {
    [Route ("api/interventions")]
    [ApiController]
    public class InterventionsController : ControllerBase {
        private readonly val_interventionsContext _context;
        public InterventionsController (val_interventionsContext context) {
            _context = context;
        }

        // // GET api/interventions/5
        // [HttpGet ("{id}")]
        // public ActionResult GetById (string Status, long id) {
        //     var item = _context.Interventions.Find (id);
        //     if (item == null) {
        //         return NotFound ("Not found");
        //     }
        //     var json = new JObject ();
        //     json["status"] = item.Status;
        //     return Content (json.ToString (), "application/json");
        // }

        // GET api/elevators/list
        [HttpGet]
        public ActionResult<List<Interventions>> GetAll () {
            var list = _context.Interventions.ToList ();
            if (list == null) {
                return NotFound ("Not Found");
            }

            List<Interventions> list_pending = new List<Interventions> ();

            foreach (var i in list) { 

                if (i.Status == "Pending" && i.InterventionStartTime == "NULL") {
                    list_pending.Add (i);
                }
            }
            return list_pending;
        }

        // PUT api/interventions/5
        [HttpPut ("{id}")]
        public ActionResult Update (long id, Interventions intervention) {
            var intrv = _context.Interventions.Find (id);
            if (intrv == null) {
                return NotFound ();
            }

            intrv.Status = intervention.Status;

            _context.Interventions.Update (intrv);
            _context.SaveChanges ();
            return NoContent ();
        }

        // // PUT api/interventions/5
        // [HttpPut ("{id}")]
        // public ActionResult Update (long id, Interventions intervention) {
        //     var intrv = _context.Interventions.Find (id);
        //     if (intrv == null) {
        //         return NotFound ();
        //     }

        //     intrv.Status = intervention.Status;

        //     _context.Interventions.Update (intrv);
        //     _context.SaveChanges ();
        //     return NoContent ();
        // }
    }
}