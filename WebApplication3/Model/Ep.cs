using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Ep
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Ssprecovered { get; set; }
        public decimal? Smprecovered { get; set; }
        public decimal? Ospprecovered { get; set; }
        public decimal? Saprecovered { get; set; }
        public decimal? Aspprecovered { get; set; }
        public decimal? NiccomponSmp { get; set; }
        public decimal? NiccomponSpp { get; set; }
        public decimal? NiccomponSap { get; set; }
        public decimal? NiccomponAspp { get; set; }
        public decimal? Cisdeductions { get; set; }
        public decimal? Nicholiday { get; set; }
        public DateTime? Submitted { get; set; }
        public decimal? NiccomponSsp { get; set; }
    }
}
