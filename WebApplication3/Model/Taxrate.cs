using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Taxrate
    {
        public string TaxYear { get; set; }
        public int? TtBandNo { get; set; }
        public string TtBandCode { get; set; }
        public decimal? TtBandWidth { get; set; }
        public decimal? TtTaxRate { get; set; }
        public decimal? TtTaxOnBand { get; set; }
        public long TtId { get; set; }
    }
}
