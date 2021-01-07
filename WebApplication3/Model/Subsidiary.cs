using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Subsidiary
    {
        public long Id { get; set; }
        public string CompanyCode { get; set; }
        public string WebPassword { get; set; }
        public DateTime? YearEnd { get; set; }
        public decimal? PercentHeld { get; set; }
    }
}
