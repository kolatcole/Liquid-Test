using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class AddContact
    {
        public long Id { get; set; }
        public long? KeyId { get; set; }
        public string BusinessName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string Birthday { get; set; }
        public string Status { get; set; }
        public string ManagerName { get; set; }
        public string AssistantName { get; set; }
        public string Notes { get; set; }
        public DateTime? ContactAdded { get; set; }
        public DateTime? ActualDate { get; set; }
        public string Mobile { get; set; }
    }
}
