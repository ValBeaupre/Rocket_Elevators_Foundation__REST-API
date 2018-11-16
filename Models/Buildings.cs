using System;
using System.Collections.Generic;

namespace Rocket.Models
{
    public partial class Buildings
    {
        public Buildings()
        {
            Batteries = new HashSet<Batteries>();
            BuildingDetails = new HashSet<BuildingDetails>();
            Interventions = new HashSet<Interventions>();
        }

        public long Id { get; set; }
        public long? CustomerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long? AddressId { get; set; }
        public string AdministratorFullName { get; set; }
        public string AdministratorPhone { get; set; }
        public string AdministratorEmail { get; set; }
        public string TechnicianFullName { get; set; }
        public string TechnicianPhone { get; set; }
        public string TechnicianEmail { get; set; }
        public string BuildingName { get; set; }

        public Addresses Address { get; set; }
        public Customers Customer { get; set; }
        public ICollection<Batteries> Batteries { get; set; }
        public ICollection<BuildingDetails> BuildingDetails { get; set; }
        public ICollection<Interventions> Interventions { get; set; }
    }
}
