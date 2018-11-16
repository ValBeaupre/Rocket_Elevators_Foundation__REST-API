using System;
using System.Collections.Generic;

namespace Rocket.Models {
    public partial class Batteries {
        public Batteries () {
            Columns = new HashSet<Columns> ();
        }

        public long Id { get; set; }
        public long? BuildingId { get; set; }
        public string BuildingType { get; set; }
        public string Status { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? InServiceSince { get; set; }
        public DateTime? LastInspection { get; set; }
        public string OperationsCertificate { get; set; }
        public string Information { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Buildings Building { get; set; }
        public Employees Employee { get; set; }
        public ICollection<Columns> Columns { get; set; }
    }
}