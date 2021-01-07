using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Ybpayment
    {
        public string TaxYear { get; set; }
        public DateTime? DateEnded { get; set; }
        public DateTime? PayDate { get; set; }
        public decimal? Amount { get; set; }
        public long Id { get; set; }
    }
}
