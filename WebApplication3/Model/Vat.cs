using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Vat
    {
        public string VatCode { get; set; }
        public decimal? VatRate { get; set; }
        public string VatDescription { get; set; }
        public decimal? VatNBox { get; set; }
        public decimal? VatVBox { get; set; }
        public string VatNumber { get; set; }
        public string VatType { get; set; }
        public bool? UseInSales { get; set; }
        public bool? UseInPurchases { get; set; }
        public string InputOrOutput { get; set; }
        public int? VatOrder { get; set; }
    }
}
