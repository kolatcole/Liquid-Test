using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Bomtype
    {
        public Bomtype()
        {
            Bomitems = new HashSet<Bomitem>();
            Bomstatuses = new HashSet<Bomstatus>();
        }

        public int BomtypeId { get; set; }
        public string Bomtype1 { get; set; }

        public virtual ICollection<Bomitem> Bomitems { get; set; }
        public virtual ICollection<Bomstatus> Bomstatuses { get; set; }
    }
}
