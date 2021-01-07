using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Currency
    {
        public string CurrCode { get; set; }
        public string Swift { get; set; }
        public string Detail { get; set; }
        public decimal? CurrRate { get; set; }
    }
}
