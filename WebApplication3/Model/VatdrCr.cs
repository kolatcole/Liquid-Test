using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class VatdrCr
    {
        public long Id { get; set; }
        public string DrCr { get; set; }
        public string Acct { get; set; }
        public decimal? Amount { get; set; }
        public string Vatcode { get; set; }
        public decimal? Vat { get; set; }
        public string Flagged { get; set; }
        public string ChangedReason { get; set; }
    }
}
