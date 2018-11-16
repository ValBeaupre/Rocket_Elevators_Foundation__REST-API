using System;
using System.Collections.Generic;

namespace Rocket.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Buildings = new HashSet<Buildings>();
            Interventions = new HashSet<Interventions>();
        }

        public long Id { get; set; }
        public long? UserId { get; set; }
        public string BusinessName { get; set; }
        public long? AddressId { get; set; }
        public string ContactFullName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string BusinessDescription { get; set; }
        public string TechnicianFullName { get; set; }
        public string TechnicianPhone { get; set; }
        public string TechnicianEmail { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long? LeadId { get; set; }

        public Addresses Address { get; set; }
        public Leads Lead { get; set; }
        public Users User { get; set; }
        public ICollection<Buildings> Buildings { get; set; }
        public ICollection<Interventions> Interventions { get; set; }
    }
}
