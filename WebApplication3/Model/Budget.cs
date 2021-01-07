using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Budget
    {
        public long BudId { get; set; }
        public DateTime? BudYear { get; set; }
        public string BudDept { get; set; }
        public string BudCode { get; set; }
        public int? Period { get; set; }
        public decimal? Amount { get; set; }
    }
}
