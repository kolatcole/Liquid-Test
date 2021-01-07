using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Task
    {
        public long Id { get; set; }
        public long? ContactId { get; set; }
        public long? CompanyId { get; set; }
        public long? ProjectId { get; set; }
        public long? Assignee { get; set; }
        public string Assignor { get; set; }
        public DateTime? TaskDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? Enddate { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string Status { get; set; }
        public string RepeatEvery { get; set; }
        public string Account { get; set; }
        public string AcctRef { get; set; }
        public string Type { get; set; }
    }
}
