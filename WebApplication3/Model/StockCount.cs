using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class StockCount
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Detail { get; set; }
        public decimal? Count { get; set; }
    }
}
