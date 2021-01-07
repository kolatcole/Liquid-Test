using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Bomstatus
    {
        public Bomstatus()
        {
            Bomcomponents = new HashSet<Bomcomponent>();
            Bomitems = new HashSet<Bomitem>();
        }

        public int BomstatusId { get; set; }
        public int BomtypeId { get; set; }
        public string Bomstatus1 { get; set; }

        public virtual Bomtype Bomtype { get; set; }
        public virtual ICollection<Bomcomponent> Bomcomponents { get; set; }
        public virtual ICollection<Bomitem> Bomitems { get; set; }
    }
}
