using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Grnsale
    {
        public long Id { get; set; }
        public string OrderNo { get; set; }
        public int? Line { get; set; }
        public decimal? Packs { get; set; }
        public string Grnno { get; set; }
        public string SaleInvNo { get; set; }
        public int? SaleInvLine { get; set; }
    }
}
