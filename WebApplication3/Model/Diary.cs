using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Diary
    {
        public long Id { get; set; }
        public string Duser { get; set; }
        public string Task { get; set; }
        public string ProgramToRun { get; set; }
        public DateTime? RunDate { get; set; }
        public string Frequency { get; set; }
        public int? Days { get; set; }
        public string RunBy { get; set; }
        public DateTime? DateRun { get; set; }
    }
}
