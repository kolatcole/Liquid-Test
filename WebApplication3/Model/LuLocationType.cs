using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class LuLocationType
    {
        public LuLocationType()
        {
            Locations = new HashSet<Location>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public bool? AllowSales { get; set; }
        public bool? AllowPurchase { get; set; }

        public virtual ICollection<Location> Locations { get; set; }
    }
}
