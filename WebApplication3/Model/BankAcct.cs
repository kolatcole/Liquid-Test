using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class BankAcct
    {
        public long? Dorder { get; set; }
        public string SortCode { get; set; }
        public string AcctNo { get; set; }
        public string RollNo { get; set; }
        public string AcctCode { get; set; }
        public string ReceiptsControl { get; set; }
        public string PaidControl { get; set; }
        public string CurrCode { get; set; }
        public long Id { get; set; }
        public string AcctName { get; set; }
        public bool? UseOnInvoice { get; set; }
        public string Swiftcode { get; set; }
        public string BankName { get; set; }
        public string BankAddress { get; set; }
        public string Iban { get; set; }
        public string ImportFileName { get; set; }
        public string StatFreq { get; set; }
        public int? StatUsualDay { get; set; }
        public bool? Exclude { get; set; }
        public bool? CashPayments { get; set; }
        public string Forex { get; set; }
    }
}
