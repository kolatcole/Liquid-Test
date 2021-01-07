using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Term
    {
        public long Id { get; set; }
        public int? Terms { get; set; }
        public string Letter1 { get; set; }
        public string Letter2 { get; set; }
        public string Letter3 { get; set; }
        public string Letter4 { get; set; }
        public int? Days1 { get; set; }
        public int? Days2 { get; set; }
        public int? Days3 { get; set; }
        public int? Days4 { get; set; }
        public int? Days5 { get; set; }
        public int? Days6 { get; set; }
        public int? Days7 { get; set; }
        public int? Days8 { get; set; }
        public int? Days9 { get; set; }
        public string SignOff { get; set; }
    }
}
