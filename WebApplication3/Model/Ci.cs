using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Ci
    {
        public long Id { get; set; }
        public string SuppCode { get; set; }
        public DateTime? Date { get; set; }
        public string Cistype { get; set; }
        public decimal? Labour { get; set; }
        public string LabNom { get; set; }
        public string LabCosting { get; set; }
        public decimal? Materials { get; set; }
        public string MatNom { get; set; }
        public string MatCosting { get; set; }
        public decimal? Vat { get; set; }
        public decimal? TaxDeducted { get; set; }
        public string InvNo { get; set; }
        public string TheirRef { get; set; }
        public decimal? Paid { get; set; }
        public string PaidRef { get; set; }
    }
}
