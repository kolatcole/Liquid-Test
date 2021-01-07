using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class AuditDelete
    {
        public long AdKey { get; set; }
        public string AdAudit { get; set; }
        public string AdCode { get; set; }
        public DateTime? AdYearEnd { get; set; }
        public int? AdPeriod { get; set; }
        public string AdSource { get; set; }
        public string AdRef { get; set; }
        public string AdDetail { get; set; }
        public decimal? AdNet { get; set; }
        public decimal? AdVat { get; set; }
        public string AdVatcode { get; set; }
        public string AdVatreturn { get; set; }
        public string AdStock { get; set; }
        public decimal? AdQty { get; set; }
        public DateTime? AdDate { get; set; }
        public string AdBy { get; set; }
        public DateTime? AdonDate { get; set; }
        public string AdVatflagged { get; set; }
    }
}
