using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Country
    {
        public string CoCountry { get; set; }
        public string CoTelCode { get; set; }
        public string CoIntrastatCde { get; set; }
        public string CoVatCode { get; set; }
        public string CoVcLength { get; set; }
        public string CoCurrencyCode { get; set; }
        public string CoCurrencyDesc { get; set; }
        public decimal? CoCurrExcRate { get; set; }
        public DateTime? CoCurrDateChg { get; set; }
        public string CoSwiftcode { get; set; }
        public string CoVatnumber { get; set; }
        public string Isocode { get; set; }
    }
}
