using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class BatchFile
    {
        public long Id { get; set; }
        public string UserCode { get; set; }
        public string Ledger { get; set; }
        public string Acct { get; set; }
        public DateTime? Date { get; set; }
        public string OurInvNo { get; set; }
        public string TheirRef { get; set; }
        public string Detail { get; set; }
        public decimal? Net { get; set; }
        public string Vatcode { get; set; }
        public decimal? Vat { get; set; }
        public string NomCode { get; set; }
        public string Costing { get; set; }
        public string Comments { get; set; }
        public bool? Posted { get; set; }
        public string Repeat { get; set; }
        public int? LineNo { get; set; }
        public string CurrCode { get; set; }
    }
}
