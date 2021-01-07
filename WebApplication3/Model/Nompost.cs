using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Nompost
    {
        public DateTime? NpDate { get; set; }
        public string NpCompany { get; set; }
        public DateTime? NpYearEnd { get; set; }
        public int? NpPostPer { get; set; }
        public int? NpTranNo { get; set; }
        public string NpSource { get; set; }
        public string NpRef { get; set; }
        public string NpCode { get; set; }
        public string NpDetail { get; set; }
        public decimal? NpNet { get; set; }
        public string NpVatcode { get; set; }
        public decimal? NpVat { get; set; }
        public string NpDept { get; set; }
        public string NpCosting { get; set; }
        public string NpPosted { get; set; }
        public long NpKey { get; set; }
        public string Curr { get; set; }
        public decimal? ExchRate { get; set; }
        public bool? IsCredit { get; set; }
        public string NpType { get; set; }
        public decimal? NpValue { get; set; }
        public int? NpIteration { get; set; }
        public int? NpPeriod { get; set; }
    }
}
