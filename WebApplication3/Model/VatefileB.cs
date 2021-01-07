using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class VatefileB
    {
        public long Id { get; set; }
        public string Vatno { get; set; }
        public string Period { get; set; }
        public decimal? Box1 { get; set; }
        public decimal? Box2 { get; set; }
        public decimal? Box3 { get; set; }
        public decimal? Box4 { get; set; }
        public decimal? Box5 { get; set; }
        public decimal? Box6 { get; set; }
        public decimal? Box7 { get; set; }
        public decimal? Box8 { get; set; }
        public decimal? Box9 { get; set; }
        public decimal? Box10 { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? EfileDate { get; set; }
        public string Response { get; set; }
    }
}
