using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Reportsdb
    {
        public string RepTable { get; set; }
        public string RepDesc { get; set; }
        public string RepSelDates { get; set; }
        public int? RepPermission { get; set; }
        public string RepFile { get; set; }
        public long RepKey { get; set; }
        public byte? RepOrder { get; set; }
        public string HelpText { get; set; }
        public string Menu { get; set; }
        public string ForeColor { get; set; }
        public string BackColor { get; set; }
        public string SelectColor { get; set; }
        public string Traditional { get; set; }
    }
}
