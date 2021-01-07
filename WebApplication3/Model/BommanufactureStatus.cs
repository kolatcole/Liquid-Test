using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class BommanufactureStatus
    {
        public BommanufactureStatus()
        {
            Bommanufactures = new HashSet<Bommanufacture>();
        }

        public int ManufactureStatusId { get; set; }
        public string ManufactureStatus { get; set; }

        public virtual ICollection<Bommanufacture> Bommanufactures { get; set; }
    }
}
