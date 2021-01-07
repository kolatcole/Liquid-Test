using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class BankAudit
    {
        public long Id { get; set; }
        public string BatchId { get; set; }
        public long? Nltkey { get; set; }
        public decimal? Value { get; set; }
        public bool? Checked { get; set; }
        public DateTime? PaidDate { get; set; }
        public bool? Rback { get; set; }
    }
}
