using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class StockCostAssigned
    {
        public int AssignId { get; set; }
        public int CostingId { get; set; }
        public DateTime AssignedDate { get; set; }
        public string AssignedReference { get; set; }
        public int QtyAssigned { get; set; }
        public decimal? Cost { get; set; }
        public int CostingTypeId { get; set; }
    }
}
