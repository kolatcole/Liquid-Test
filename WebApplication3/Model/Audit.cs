using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Audit
    {
        public long Id { get; set; }
        public string AuditRef { get; set; }
        public long? UserId { get; set; }
        public DateTime? Date { get; set; }
        public string Action { get; set; }
        public string Changes { get; set; }
    }
}
