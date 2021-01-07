using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Smp
    {
        public long Id { get; set; }
        public string EeCode { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? Ewc { get; set; }
        public decimal? AverageEarnings { get; set; }
        public DateTime? ActualStartDate { get; set; }
    }
}
