using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class DebtManage
    {
        public long Dmkey { get; set; }
        public string Dmsession { get; set; }
        public string Dmacct { get; set; }
        public int? Dmtype { get; set; }
        public DateTime? Dmcreated { get; set; }
    }
}
