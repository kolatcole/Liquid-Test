using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Epo
    {
        public long Id { get; set; }
        public long? TillId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Each { get; set; }
        public decimal? Total { get; set; }
        public decimal? Vat { get; set; }
        public string Vatcode { get; set; }
    }
}
