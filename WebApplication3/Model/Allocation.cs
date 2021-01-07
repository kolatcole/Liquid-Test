using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Allocation
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public DateTime? Date { get; set; }
        public string Acct { get; set; }
        public string Ref { get; set; }
        public decimal? Allocated { get; set; }
        public decimal? AllocatedCurr { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
