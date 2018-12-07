using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Rocket.Models;

namespace Rocket.Controllers {

    [Route ("api/elevators")]
    [ApiController]
    public class ElevatorsControllers : ControllerBase {
        private readonly valerieContext _context;

        public ElevatorsControllers (valerieContext context) {
            _context = context;
        }

        
        // GET api/elevators/all : to get the full elevators list
        [HttpGet ("all")]
        public ActionResult<List<Elevators>> GetAll () {
            return _context.Elevators.ToList ();
        }


        // GET api/elevators/list
        [HttpGet ("list")]
        public ActionResult<List<Elevators>> GetList () {
            var list = _context.Elevators.ToList ();
            if (list == null) {
                return NotFound ("Not Found");
            }
            List<Elevators> list_alarm_inac = new List<Elevators> ();

            foreach (var e in list) {

                if (e.Status == "Alarm" || e.Status == "Inactive") {
                    list_alarm_inac.Add (e);
                }
            }
            return list_alarm_inac;
        }


        // GET api/elevators/5
        [HttpGet ("{id}", Name = "GetElevators")]
        public ActionResult GetById (string Status, long id) {
            var item = _context.Elevators.Find (id);
            if (item == null) {
                return NotFound ("Not Found");
            }
            var json = new JObject ();
            json["status"] = item.Status;
            return Content (json.ToString (), "application/json");
        }


        // PUT api/elevators/5
        [HttpPut ("{id}")]
        public ActionResult Update (long id, Elevators elevator) {
            var elv = _context.Elevators.Find (id);
            if (elv == null) {
                return NotFound ();
            }

            elv.Status = elevator.Status;

            _context.Elevators.Update (elv);
            _context.SaveChanges ();
            return NoContent ();
        }
    }
}