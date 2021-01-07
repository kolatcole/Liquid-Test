using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Slnote
    {
        public long Slnkey { get; set; }
        public string Slncode { get; set; }
        public DateTime? Slndate { get; set; }
        public string Slnnotes { get; set; }
        public DateTime? SlnfollowUp { get; set; }
        public string Slnto { get; set; }
        public string Slnfrom { get; set; }
        public string Slnattachment { get; set; }
        public string Slnsubject { get; set; }
        public string Slncomments { get; set; }
    }
}
