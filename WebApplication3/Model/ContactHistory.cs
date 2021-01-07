using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class ContactHistory
    {
        public long HistoryId { get; set; }
        public long? Id { get; set; }
        public string History { get; set; }
        public DateTime? Date { get; set; }
        public string ModeOfContact { get; set; }
        public long? UserId { get; set; }
        public long? CoKey { get; set; }
        public int? Hours { get; set; }
        public int? Mins { get; set; }
        public string JobType { get; set; }
    }
}
