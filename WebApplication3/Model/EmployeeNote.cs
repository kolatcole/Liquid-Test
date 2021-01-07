using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class EmployeeNote
    {
        public long Id { get; set; }
        public DateTime? Date { get; set; }
        public string Note { get; set; }
        public long? EmployeeId { get; set; }
    }
}
