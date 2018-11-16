using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Rocket.Models;

namespace Rocket.Controllers {
    [Route ("api/columns")]
    [ApiController]
    public class ColumnsController : ControllerBase {
        private readonly val_interventionsContext _context;

        public ColumnsController (val_interventionsContext context) {
            _context = context;
        }

        // GET api/columns
        [HttpGet]
        public ActionResult<List<Columns>> GetAll () {
            var list = _context.Columns.ToList ();
            if (list == null) {
                return NotFound ("Not Found");
            }
            List<Columns> list_alarm_inac = new List<Columns> ();

            foreach (var c in list) {

                if (c.Status == "Inactive") {
                    list_alarm_inac.Add (c);
                }
            }
            return list_alarm_inac;
        }

        // GET api/columns/5
        [HttpGet ("{id}")]
        public ActionResult GetById (string Status, long id) {
            var item = _context.Columns.Find (id);
            if (item == null) {
                return NotFound ("Not found");
            }
            var json = new JObject ();
            json["status"] = item.Status;
            return Content (json.ToString (), "application/json");
        }

        // PUT api/batteries/5
        [HttpPut ("{id}")]
        public ActionResult Update (long id, Columns column) {
            var col = _context.Columns.Find (id);
            if (col == null) {
                return NotFound ();
            }

            col.Status = column.Status;

            _context.Columns.Update (col);
            _context.SaveChanges ();
            return NoContent ();
        }
    }
}