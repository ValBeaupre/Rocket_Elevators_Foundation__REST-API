using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Rocket.Models;
using System;
using System.Linq;

namespace Rocket.Controllers {
    [Route ("api/buildings")]
    [ApiController]
    public class BuildingsController : ControllerBase {
        private readonly val_interventionsContext _context;
        public BuildingsController (val_interventionsContext context) {
            _context = context;
        }


        // GET api/buildings/list
        [HttpGet ("list")]
        public ActionResult<List<Buildings>> GetList () {
            var list = _context.Buildings
                .Include (bu => bu.Batteries)
                .ThenInclude (b => b.Columns)
                .ThenInclude (c => c.Elevators);

            if (list == null) {
                return NotFound ("Not Found");
            }

            // To build a "Buildings" list
            List<Buildings> list_buildings_intervention = new List<Buildings> ();
            var verification = false;

            foreach (var building in list) {
                verification = false;
                foreach (var battery in building.Batteries) {
                    if (battery.Status == "Intervention") {
                        verification = true;
                    }
                    foreach (var column in battery.Columns) {
                        if (column.Status == "Intervention") {
                            verification = true;
                        }

                        foreach (var elevator in column.Elevators) {
                            if (elevator.Status == "Intervention") {
                                verification = true;
                            }
                        }
                    }
                }
                if (verification == true) {
                    var found_building = _context.Buildings.Find (building.Id);
                    list_buildings_intervention.Add (found_building);
                }
            }
            return list_buildings_intervention.ToList();
        }


        // GET api/buildings/all
        [HttpGet("all")]
        public ActionResult<List<Buildings>> GetAll(){
           return _context.Buildings.ToList();
        }
    }
}