using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Dept
    {
        public string DeptName { get; set; }
        public string DeptDesc { get; set; }
        public string DeptManager { get; set; }
        public string DeptOwner { get; set; }
        public string DeptStat { get; set; }
        public long DeptId { get; set; }
        public DateTime? DeptEndDate { get; set; }
        public decimal? BudgetSales { get; set; }
        public decimal? BudgetCosts { get; set; }
        public string Status { get; set; }
        public string GroupName { get; set; }
    }
}
