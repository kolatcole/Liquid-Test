using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Bomitem
    {
        public Bomitem()
        {
            Bomcomponents = new HashSet<Bomcomponent>();
            Bommanufactures = new HashSet<Bommanufacture>();
        }

        public string Bomcode { get; set; }
        public string Bomdescription { get; set; }
        public int BomtypeId { get; set; }
        public int BomstatusId { get; set; }
        public int BomtrackId { get; set; }
        public bool BomisUniqueSerial { get; set; }
        public string BomunitOfMeasure { get; set; }
        public string BomdefaultLocation { get; set; }

        public virtual Location BomdefaultLocationNavigation { get; set; }
        public virtual Bomstatus Bomstatus { get; set; }
        public virtual Bomtracking Bomtrack { get; set; }
        public virtual Bomtype Bomtype { get; set; }
        public virtual ICollection<Bomcomponent> Bomcomponents { get; set; }
        public virtual ICollection<Bommanufacture> Bommanufactures { get; set; }
    }
}
