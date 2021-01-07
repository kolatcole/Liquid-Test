using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Deposit
    {
        public long Id { get; set; }
        public string OrderNo { get; set; }
        public string Type { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? DepositDate { get; set; }
    }
}
