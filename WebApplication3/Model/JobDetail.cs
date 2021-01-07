using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class JobDetail
    {
        public long Id { get; set; }
        public string AcctRef { get; set; }
        public string JobRef { get; set; }
        public string JobUser { get; set; }
        public string Details { get; set; }
        public string Address { get; set; }
        public string Names { get; set; }
        public DateTime? Date { get; set; }
    }
}
