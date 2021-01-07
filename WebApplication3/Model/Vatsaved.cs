using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Vatsaved
    {
        public long Id { get; set; }
        public long? Grid { get; set; }
        public DateTime? Datetime { get; set; }
        public string EnteredBy { get; set; }
        public string Period { get; set; }
        public string Vatcode { get; set; }
        public long? NetBox { get; set; }
        public decimal? Net { get; set; }
        public long? Vatbox { get; set; }
        public decimal? Vat { get; set; }
        public decimal? CurrNet { get; set; }
        public decimal? CurrVat { get; set; }
    }
}
