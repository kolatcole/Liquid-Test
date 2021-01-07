using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class StandingOrder
    {
        public long Id { get; set; }
        public DateTime? Date { get; set; }
        public string Detail { get; set; }
        public decimal? Net { get; set; }
        public string Vatcode { get; set; }
        public decimal? Vat { get; set; }
        public string Code { get; set; }
        public string Costing { get; set; }
        public DateTime? ValidTo { get; set; }
        public string Repeat { get; set; }
        public DateTime? LastPosted { get; set; }
    }
}
