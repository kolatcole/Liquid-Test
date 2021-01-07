using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class AnalysisMaster
    {
        public long Id { get; set; }
        public string Template { get; set; }
        public string Detail { get; set; }
        public string Type { get; set; }
        public string Col { get; set; }
        public string Acct { get; set; }
        public string DebitCredit { get; set; }
        public string Formula { get; set; }
        public bool? Enabled { get; set; }
        public string DefaultValue { get; set; }
        public int? CellWidth { get; set; }
        public string Vattreatment { get; set; }
    }
}
