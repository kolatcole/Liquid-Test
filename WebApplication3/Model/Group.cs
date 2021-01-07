using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Group
    {
        public long GroupId { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
        public bool? NotActive { get; set; }
    }
}
