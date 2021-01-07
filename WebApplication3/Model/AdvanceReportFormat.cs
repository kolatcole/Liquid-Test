using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class AdvanceReportFormat
    {
        public int? ReportId { get; set; }
        public string Columns { get; set; }
        public string Align { get; set; }
        public string Font { get; set; }
        public bool? IsVisible { get; set; }
        public int? Rounding { get; set; }
        public int Id { get; set; }
        public bool? Header { get; set; }
        public bool? Footer { get; set; }
        public bool? Total { get; set; }
        public int? SubTotalColumn { get; set; }
    }
}
