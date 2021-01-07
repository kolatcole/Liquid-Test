using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Position
    {
        public long PositionId { get; set; }
        public string Position1 { get; set; }
        public string Description { get; set; }
        public int? Order { get; set; }
    }
}
