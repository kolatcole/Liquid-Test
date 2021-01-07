using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class DebtChase
    {
        public string InvNo { get; set; }
        public DateTime? DateSent { get; set; }
        public int? Type { get; set; }
        public string Status { get; set; }
    }
}
