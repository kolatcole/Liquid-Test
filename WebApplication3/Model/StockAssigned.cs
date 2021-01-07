using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class StockAssigned
    {
        public StockAssigned()
        {
            BommanufactureComponents = new HashSet<BommanufactureComponent>();
        }

        public int StockAssignId { get; set; }
        public int TrackingId { get; set; }
        public DateTime AssignedDate { get; set; }
        public string AssignedReference { get; set; }
        public int QtyAssigned { get; set; }

        public virtual StockTracking Tracking { get; set; }
        public virtual ICollection<BommanufactureComponent> BommanufactureComponents { get; set; }
    }
}
