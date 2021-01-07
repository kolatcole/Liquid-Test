using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Ssp
    {
        public string EeCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Piw { get; set; }
        public decimal? QualifyDays { get; set; }
        public decimal? Due { get; set; }
        public long Id { get; set; }
    }
}
