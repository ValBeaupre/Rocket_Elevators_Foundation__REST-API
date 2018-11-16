using System;
using System.Collections.Generic;

namespace Rocket.Models
{
    public partial class Elevators
    {
        public Elevators()
        {
            Interventions = new HashSet<Interventions>();
        }

        public long Id { get; set; }
        public long? ColumnId { get; set; }
        public int? SerialNumber { get; set; }
        public string Model { get; set; }
        public string BuildingType { get; set; }
        public string Status { get; set; }
        public DateTime? InServiceSince { get; set; }
        public DateTime? LastInspection { get; set; }
        public string InspectionCertificate { get; set; }
        public string Information { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Columns Column { get; set; }
        public ICollection<Interventions> Interventions { get; set; }
    }
}
