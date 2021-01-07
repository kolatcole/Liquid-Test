using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Payrate
    {
        public long Id { get; set; }
        public string PrEeCode { get; set; }
        public string EePrNomCode { get; set; }
        public int? EePrLine { get; set; }
        public string EePrDesc { get; set; }
        public double? EePrRate { get; set; }
        public double? EePrTime { get; set; }
        public int? EePrNetPay { get; set; }
        public string EePrTaxable { get; set; }
        public string EePrNiable { get; set; }
        public string EePrClient { get; set; }
        public DateTime? EePrDate { get; set; }
        public string EePrDuty { get; set; }
        public string EePrAuditRef { get; set; }
        public string EePrCosting { get; set; }
        public bool? EePrPosted { get; set; }
    }
}
