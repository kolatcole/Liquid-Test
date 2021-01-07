using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class SerialNumber
    {
        public string SerialNumber1 { get; set; }
        public DateTime EntryDate { get; set; }
        public int EnteredBy { get; set; }
        public int StatusId { get; set; }

        public virtual NumberStatus Status { get; set; }
    }
}
