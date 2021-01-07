using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class ReportTemplate
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public int? Line { get; set; }
        public string GroupAcct { get; set; }
        public string GroupAcctCode { get; set; }
        public string Type { get; set; }
        public string Detail { get; set; }
        public int? PrintCol { get; set; }
        public string AccumAction { get; set; }
        public int? Accumulator { get; set; }
    }
}
