using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Timesheet
    {
        public long Id { get; set; }
        public string Client { get; set; }
        public string WorkType { get; set; }
        public decimal? Units { get; set; }
        public string Detail { get; set; }
        public DateTime? WorkDate { get; set; }
        public long? Employee { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public bool? InvoiceFlag { get; set; }
        public DateTime? PayrollFlagged { get; set; }
    }
}
