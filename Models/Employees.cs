using System;
using System.Collections.Generic;

namespace Rocket.Models {
    public partial class Employees {
        public Employees () {
            Batteries = new HashSet<Batteries> ();
        }

        public long Id { get; set; }
        public long? UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Users User { get; set; }
        public ICollection<Batteries> Batteries { get; set; }
    }
}