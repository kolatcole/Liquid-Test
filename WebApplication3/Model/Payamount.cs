using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Payamount
    {
        public long Id { get; set; }
        public string EeCode { get; set; }
        public string EeNomCode { get; set; }
        public int? EePayLine { get; set; }
        public string EePayDesc { get; set; }
        public double? EePayRate { get; set; }
        public double? EePayTime { get; set; }
        public int? EeNetPayReqd { get; set; }
        public bool? EeTaxable { get; set; }
        public bool? EeNiable { get; set; }
        public double? EeTotReqd { get; set; }
        public double? EeDedToDate { get; set; }
        public string EeAuditRef { get; set; }
        public bool? EeDoNotDelete { get; set; }
        public string EeCosting { get; set; }
    }
}
