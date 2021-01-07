using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Price
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public DateTime? Date { get; set; }
        public string StockCode { get; set; }
        public double? CostPrice { get; set; }
        public double? UnitPrice { get; set; }
        public double? Discount { get; set; }
        public double? ForQty { get; set; }
        public string QuotedBy { get; set; }
        public string Notes { get; set; }
        public string Currency { get; set; }
    }
}
