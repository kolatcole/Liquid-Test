using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Bommanufacture
    {
        public Bommanufacture()
        {
            BommanufactureAdditionalCosts = new HashSet<BommanufactureAdditionalCost>();
            BommanufactureComponents = new HashSet<BommanufactureComponent>();
        }

        public string BommanufacturingReference { get; set; }
        public string Bomcode { get; set; }
        public double Qtymanufactured { get; set; }
        public double BomunitCost { get; set; }
        public int ManufactureStatusId { get; set; }
        public string Bomwarehouse { get; set; }
        public string Bomtype { get; set; }
        public DateTime? Bomdate { get; set; }
        public string TrackingNumber { get; set; }

        public virtual Bomitem BomcodeNavigation { get; set; }
        public virtual Location BomwarehouseNavigation { get; set; }
        public virtual BommanufactureStatus ManufactureStatus { get; set; }
        public virtual ICollection<BommanufactureAdditionalCost> BommanufactureAdditionalCosts { get; set; }
        public virtual ICollection<BommanufactureComponent> BommanufactureComponents { get; set; }
    }
}
