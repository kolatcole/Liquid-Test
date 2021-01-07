using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class AnalysisValue
    {
        public long Id { get; set; }
        public string Template { get; set; }
        public string Ref { get; set; }
        public string Col { get; set; }
        public string Value { get; set; }
        public bool? Posted { get; set; }
        public decimal? ValueMoney { get; set; }
    }
}
