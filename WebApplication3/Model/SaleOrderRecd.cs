using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class SaleOrderRecd
    {
        public long Id { get; set; }
        public string Acct { get; set; }
        public DateTime? Date { get; set; }
        public string InvNo { get; set; }
        public string OurRef { get; set; }
        public string TheirRef { get; set; }
        public string Nom { get; set; }
        public decimal? Amount { get; set; }
    }
}
