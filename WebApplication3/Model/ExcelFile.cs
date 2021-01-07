using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class ExcelFile
    {
        public long Id { get; set; }
        public string Template { get; set; }
        public string ExcelCell { get; set; }
        public string LinkTo { get; set; }
        public bool? Repeat { get; set; }
    }
}
