using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class LocationStock
    {
        public int LocationStockId { get; set; }
        public string LocationCode { get; set; }
        public string StockCode { get; set; }
        public double? StockSalesUnitCost { get; set; }
        public double? StockPurchaseUnitCost { get; set; }
        public int? Minimumlevel { get; set; }

        public virtual Location LocationCodeNavigation { get; set; }
        public virtual Stock StockCodeNavigation { get; set; }
    }
}
