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
        private readonly valerieContext _context;
        public InterventionsController (valerieContext context) {
            _context = context;
        }


        // GET api/interventions/all : to get the full intervention list
        [HttpGet ("all")]
        public ActionResult<List<Interventions>> GetAll () {
            return _context.Interventions.ToList ();
        }


        // GET api/interventions/pending : to get the intervention list with the "Pending" status and NO Starting Time
        [HttpGet ("pending")]
        public ActionResult<List<Interventions>> GetPending () {
            var list = _context.Interventions.ToList ();
            if (list == null) {
                return NotFound ("Not Found");
            }

            List<Interventions> list_pending = new List<Interventions> ();

            foreach (var i in list) { 

                if ((i.Status == "Pending") && (i.InterventionStartTime == null)) {
                    list_pending.Add (i);
                }
            }
            return list_pending;
        }


        // GET api/interventions/inprogresslist : to get the intervention list with the "In Progress" status
        [HttpGet ("inprogresslist")]
        public ActionResult<List<Interventions>> GetInProgress () {
            var list = _context.Interventions.ToList ();
            if (list == null) {
                return NotFound ("Not Found");
            }

            List<Interventions> list_inprogress = new List<Interventions> ();

            foreach (var i in list) { 

                if ((i.Status == "In Progress")) {
                    list_inprogress.Add (i);
                }
            }
            return list_inprogress;
        }


        // GET api/interventions/5 : to get the status of one particular intervention id
        [HttpGet ("{id}", Name = "GetInterventions")]
        public ActionResult GetById (string Status, long id) {
            var item = _context.Interventions.Find (id);
            if (item == null) {
                return NotFound ("Not Found");
            }
            var json = new JObject ();
            json["status"] = item.Status;
            return Content (json.ToString (), "application/json");
        }


        // PUT api/interventions/inprogress/id : to modify a specified intervention status from "Pending" to "In Progress"
        [HttpPut ("inprogress/{id}")]
        public string UpdateInProgress (long id) {
            var intrv = _context.Interventions.Find(id);
            if (intrv == null) {
                return "Please enter an existing intervention id" ;
            }
            if (intrv.Status != "Pending") {
                return "Please choose a Pending intervention";
            }
            else {
                intrv.Status = "In Progress";

                string InterventionStartTime = DateTime.Now.ToString("yyyy/MM/dd H:mm:ss");
                intrv.InterventionStartTime = InterventionStartTime;

                _context.Interventions.Update (intrv);
                _context.SaveChanges ();
                return "The intervention #" + intrv.Id + " status has been successufully changed to In Progress at " + intrv.InterventionStartTime;
            }   
        }


        // PUT api/interventions/completed/id : to update the status once the intervention is done
        [HttpPut ("completed/{id}")]
        public string UpdateCompleted (long id) {
            var intrv = _context.Interventions.Find (id);
            if (intrv == null) {
                return "Please enter an existing intervention id" ;
            }
            if (intrv.Status != "In Progress") {
                return "Please choose an In Progress intervention";
            }
            else {
                intrv.Status = "Completed";

                string InterventionEndTime = DateTime.Now.ToString("yyyy/MM/dd H:mm:ss");
                intrv.InterventionEndTime = InterventionEndTime;

                _context.Interventions.Update (intrv);
                _context.SaveChanges ();
                return "The intervention #" + intrv.Id + " status has been successufully changed to Completed at " + intrv.InterventionEndTime;
            }
        }
    }
}