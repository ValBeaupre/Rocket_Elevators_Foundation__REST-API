using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Rocket.Models;

namespace Rocket.Controllers {
    [Route ("api/batteries")]
    [ApiController]
    public class BatteriesController : ControllerBase {
        private readonly val_interventionsContext _context;

        public BatteriesController (val_interventionsContext context) {
            _context = context;
        }


        // GET api/batteries/all : to get the full battery list
        [HttpGet ("all")]
        public ActionResult<List<Batteries>> GetAll () {
            return _context.Batteries.ToList ();
        }


        // GET api/batteries/5 : to get a specific battery status
        [HttpGet ("{id}")]
        public ActionResult GetById (string Status, long id) {
            var item = _context.Batteries.Find (id);
            if (item == null) {
                return NotFound ("Not found");
            }
            var json = new JObject ();
            json["status"] = item.Status;
            return Content (json.ToString (), "application/json");
        }

        // PUT api/batteries/5 : to change a specific battery status
        [HttpPut ("{id}")]
        public ActionResult Update (long id, Batteries battery) {
            var bat = _context.Batteries.Find (id);
            if (bat == null) {
                return NotFound ();
            }

            bat.Status = battery.Status;

            _context.Batteries.Update (bat);
            _context.SaveChanges ();
            return NoContent ();
        }
    }
}