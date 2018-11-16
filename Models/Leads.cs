using System;
using System.Collections.Generic;

namespace Rocket.Models
{
    public partial class Leads
    {
        public Leads()
        {
            Customers = new HashSet<Customers>();
        }

        public long Id { get; set; }
        public string FullName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string Department { get; set; }
        public string Message { get; set; }
        public byte[] FileAttachment { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string OriginalFileName { get; set; }

        public ICollection<Customers> Customers { get; set; }
    }
}
