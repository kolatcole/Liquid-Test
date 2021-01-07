using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class DeptGroup
    {
        public string GroupName { get; set; }
        public string GroupDesc { get; set; }
        public long GroupId { get; set; }
        public DateTime? GroupEndDate { get; set; }
    }
}
