using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Contract
    {
        public Contract()
        {
            ContractTrans = new HashSet<ContractTran>();
        }

        public string ContractNo { get; set; }
        public string Customer { get; set; }
        public string CustOrdNo { get; set; }
        public string Supplier { get; set; }
        public string SuppOrdNo { get; set; }
        public string Product { get; set; }
        public string Detail { get; set; }
        public string SaleLocation { get; set; }
        public string PurchaseLocation { get; set; }
        public decimal? PackSize { get; set; }
        public decimal? PackWeight { get; set; }
        public decimal? TotalQty { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string DeliverTo { get; set; }
        public string CustTerms { get; set; }
        public string SuppTerms { get; set; }
        public decimal? SellUnitPrice { get; set; }
        public decimal? CostUnitPrice { get; set; }
        public string SaleVatcode { get; set; }
        public string CostVatcode { get; set; }
        public string SaleCurrCode { get; set; }
        public string PurchaseCurrCode { get; set; }
        public string CommAcct { get; set; }
        public decimal? CommRate { get; set; }

        public virtual ICollection<ContractTran> ContractTrans { get; set; }
    }
}
