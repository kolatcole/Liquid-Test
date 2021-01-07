using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class NominalOld
    {
        public string NlCompany { get; set; }
        public string NlCode { get; set; }
        public string NlDescription { get; set; }
        public string NlBalance { get; set; }
        public string NlWorkBal { get; set; }
        public string NlAcctOrder { get; set; }
        public string NlIrisCode { get; set; }
        public string NlCoCode { get; set; }
        public string NlType { get; set; }
        public bool? NlFlag { get; set; }
        public bool? NlShowSales { get; set; }
        public bool? NlShowPurchase { get; set; }
        public bool? NlShowExpense { get; set; }
        public string MergeAcct { get; set; }
        public bool? NlShowJournals { get; set; }
        public bool? NlIsblocked { get; set; }
        public bool? NlIsConfidential { get; set; }
        public string NlTaxCode { get; set; }
        public string NlCurrencyCode { get; set; }
        public string NlDepartmentCode { get; set; }
        public string NlBranchCode { get; set; }
        public bool? NlIsForex { get; set; }
        public string NlExternalRef { get; set; }
        public DateTime? NlDateCreated { get; set; }
    }
}
