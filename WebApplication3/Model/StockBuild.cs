using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class StockBuild
    {
        public long Id { get; set; }
        public string Product { get; set; }
        public string FromCode { get; set; }
        public decimal? Qty { get; set; }
    }
}
