using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Quote
    {
        public long QuoteKey { get; set; }
        public string CustCode { get; set; }
        public decimal? QuoteNo { get; set; }
        public int? QuoteLine { get; set; }
        public string CoAddress { get; set; }
        public string DelAdd { get; set; }
        public string CustOrderNo { get; set; }
        public DateTime? DateOfQuote { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string Salesman { get; set; }
        public string Notes { get; set; }
        public string StkCode { get; set; }
        public string Detail { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Weight { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? SellPrice { get; set; }
        public string Vatcode { get; set; }
        public decimal? Vat { get; set; }
        public decimal? CostPrice { get; set; }
        public string Status { get; set; }
        public string SuppCode { get; set; }
    }
}
