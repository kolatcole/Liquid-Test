using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class NltranAdd
    {
        public long Id { get; set; }
        public string InvType { get; set; }
        public string InvNo { get; set; }
        public string BatchNo { get; set; }
        public bool? Printed { get; set; }
        public bool? Completed { get; set; }
        public bool? OnHold { get; set; }
        public string OnHoldReason { get; set; }
        public DateTime? FactorDate { get; set; }
        public decimal? SettDisc { get; set; }
        public DateTime? EmailSent { get; set; }
    }
}
