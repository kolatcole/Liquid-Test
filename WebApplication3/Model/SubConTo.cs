using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class SubConTo
    {
        public long Id { get; set; }
        public string CoCode { get; set; }
        public string ConFrom { get; set; }
        public string ConTo { get; set; }
    }
}
