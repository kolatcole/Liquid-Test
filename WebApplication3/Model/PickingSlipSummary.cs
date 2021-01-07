using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class PickingSlipSummary
    {
        public string StockCode { get; set; }
        public string Description { get; set; }
        public string DeliveryNumber { get; set; }
        public string OrderNo { get; set; }
        public string CustomerName { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string CustCode { get; set; }
    }
}
