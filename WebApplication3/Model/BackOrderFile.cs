using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class BackOrderFile
    {
        public long Id { get; set; }
        public int? OrderNo { get; set; }
        public decimal? QtyDelivered { get; set; }
        public DateTime? DateDelivered { get; set; }
        public DateTime? DateEntered { get; set; }
        public string Invoice { get; set; }
        public int? OrderLine { get; set; }
        public string Location { get; set; }
    }
}
