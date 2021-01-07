using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class EeChargeRate
    {
        public long Id { get; set; }
        public long? EeId { get; set; }
        public decimal? ChargeRate { get; set; }
        public DateTime? Date { get; set; }
        public string Type { get; set; }
        public decimal? Cost { get; set; }
        public DateTime? PayrollUpdated { get; set; }
    }
}
