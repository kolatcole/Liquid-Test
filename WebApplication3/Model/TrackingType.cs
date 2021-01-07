using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class TrackingType
    {
        public TrackingType()
        {
            StockTrackings = new HashSet<StockTracking>();
        }

        public int TrackingTypeId { get; set; }
        public string TrackingType1 { get; set; }

        public virtual ICollection<StockTracking> StockTrackings { get; set; }
    }
}
