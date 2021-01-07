using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Treasury
    {
        public long Id { get; set; }
        public DateTime? Date { get; set; }
        public string BankAcct { get; set; }
        public string Currency { get; set; }
        public decimal? Value { get; set; }
        public decimal? Fxrate { get; set; }
        public decimal? BaseCost { get; set; }
        public string Reference { get; set; }
        public DateTime? CloseOn { get; set; }
        public bool? Closed { get; set; }
    }
}
