using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class ContractTran
    {
        public long Id { get; set; }
        public string ContractNo { get; set; }
        public DateTime? BudgetDelDate { get; set; }
        public decimal? BudgetQty { get; set; }
        public DateTime? ActualDelDate { get; set; }
        public decimal? ActQty { get; set; }
        public string SaleOrderNo { get; set; }
        public string PurchaseOrderNo { get; set; }

        public virtual Contract ContractNoNavigation { get; set; }
    }
}
