using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class BatchNumber
    {
        public string BatchNumber1 { get; set; }
        public DateTime EntryDate { get; set; }
        public int EnteredBy { get; set; }
        public int StatusId { get; set; }
        public DateTime ValidDate { get; set; }

        public virtual NumberStatus Status { get; set; }
    }
}
