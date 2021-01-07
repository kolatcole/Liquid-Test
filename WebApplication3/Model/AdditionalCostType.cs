using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class AdditionalCostType
    {
        public AdditionalCostType()
        {
            BommanufactureAdditionalCosts = new HashSet<BommanufactureAdditionalCost>();
        }

        public int AdditionalCostTypeId { get; set; }
        public string AdditionalCostType1 { get; set; }

        public virtual ICollection<BommanufactureAdditionalCost> BommanufactureAdditionalCosts { get; set; }
    }
}
