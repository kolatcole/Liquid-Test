using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class BommanufactureComponent
    {
        public int BommanufactureComponentsId { get; set; }
        public string BommanufactureReference { get; set; }
        public string Bomcomponents { get; set; }
        public double Qty { get; set; }
        public double UnitCost { get; set; }
        public string TrackingReference { get; set; }
        public int? StockAssignId { get; set; }
        public int? StockTrackingId { get; set; }

        public virtual Stock BomcomponentsNavigation { get; set; }
        public virtual Bommanufacture BommanufactureReferenceNavigation { get; set; }
        public virtual StockAssigned StockAssign { get; set; }
        public virtual StockTracking StockTracking { get; set; }
    }
}
