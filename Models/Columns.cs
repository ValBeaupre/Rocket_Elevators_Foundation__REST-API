using System;
using System.Collections.Generic;

namespace Rocket.Models {
    public partial class Columns {
        public Columns () {
            Elevators = new HashSet<Elevators> ();
        }

        public long Id { get; set; }
        public long? BatteryId { get; set; }
        public string BuildingType { get; set; }
        public int? FloorsServed { get; set; }
        public string Status { get; set; }
        public string Information { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Batteries Battery { get; set; }
        public ICollection<Elevators> Elevators { get; set; }
    }
}