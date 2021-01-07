using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Bomtracking
    {
        public Bomtracking()
        {
            Bomitems = new HashSet<Bomitem>();
        }

        public int BomtrackId { get; set; }
        public string Bomtracking1 { get; set; }

        public virtual ICollection<Bomitem> Bomitems { get; set; }
    }
}
