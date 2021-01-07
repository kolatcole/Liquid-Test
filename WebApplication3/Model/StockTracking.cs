using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class StockTracking
    {
        public StockTracking()
        {
            BommanufactureComponents = new HashSet<BommanufactureComponent>();
            StockAssigneds = new HashSet<StockAssigned>();
        }

        public int TrackingId { get; set; }
        public DateTime TrackingEntryDate { get; set; }
        public int TrackingTypeId { get; set; }
        public string TrackingReference { get; set; }
        public string TrackingNo { get; set; }
        public bool IsSerial { get; set; }
        public string StockItem { get; set; }
        public double Qty { get; set; }
        public string LocationCode { get; set; }

        public virtual Location LocationCodeNavigation { get; set; }
        public virtual TrackingType TrackingType { get; set; }
        public virtual ICollection<BommanufactureComponent> BommanufactureComponents { get; set; }
        public virtual ICollection<StockAssigned> StockAssigneds { get; set; }
    }
}
