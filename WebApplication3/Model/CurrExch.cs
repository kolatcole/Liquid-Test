using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class CurrExch
    {
        public long Id { get; set; }
        public DateTime? Date { get; set; }
        public string Currency { get; set; }
        public decimal? Rate { get; set; }
    }
}
