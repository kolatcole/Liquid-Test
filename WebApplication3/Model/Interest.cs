using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Interest
    {
        public long InterestId { get; set; }
        public string Interest1 { get; set; }
        public string Description { get; set; }
        public long CatId { get; set; }
    }
}
