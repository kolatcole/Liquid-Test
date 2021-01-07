using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class StockCosting
    {
        public int CostingId { get; set; }
        public DateTime CostingEntryDate { get; set; }
        public int CostingTypeId { get; set; }
        public string CostingReference { get; set; }
        public string StockItem { get; set; }
        public decimal? UnitCost { get; set; }
        public double Qty { get; set; }
        public string LocationCode { get; set; }
    }
}
