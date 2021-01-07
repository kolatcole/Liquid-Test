using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class YearEndReport
    {
        public long Id { get; set; }
        public DateTime? Date { get; set; }
        public string Ledger { get; set; }
        public string Code { get; set; }
        public decimal? Value { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? YearEnd { get; set; }
    }
}
