using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class BommanufactureAdditionalCost
    {
        public int AdditionalCostId { get; set; }
        public string BommanufactureReference { get; set; }
        public int AdditionalCostTypeId { get; set; }
        public double CostLeadTime { get; set; }
        public double Cost { get; set; }

        public virtual AdditionalCostType AdditionalCostType { get; set; }
        public virtual Bommanufacture BommanufactureReferenceNavigation { get; set; }
    }
}
