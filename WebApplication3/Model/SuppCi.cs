using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class SuppCi
    {
        public long Id { get; set; }
        public string SuppId { get; set; }
        public string VerificationNo { get; set; }
        public string Utr { get; set; }
        public string Nino { get; set; }
        public bool? UnmatchedRate { get; set; }
        public string TaxTreatment { get; set; }
        public string TradingType { get; set; }
        public string Putr { get; set; }
        public string Crn { get; set; }
        public string WksNo { get; set; }
        public string TradingName { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Add3 { get; set; }
        public string Add4 { get; set; }
        public string PostCode { get; set; }
        public string Phone { get; set; }
        public DateTime? LastVerified { get; set; }
    }
}
