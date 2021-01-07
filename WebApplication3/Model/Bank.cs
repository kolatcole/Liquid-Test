using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Bank
    {
        public string BankNo { get; set; }
        public DateTime? BankDate { get; set; }
        public string BankAcct { get; set; }
        public decimal? BankAmount { get; set; }
        public string BankSubCat { get; set; }
        public string BankMemo { get; set; }
        public string BankSource { get; set; }
        public string BankNominal { get; set; }
        public decimal? BankNet { get; set; }
        public string BankVatcode { get; set; }
        public decimal? BankVat { get; set; }
        public string BankRef { get; set; }
        public string BankDetail { get; set; }
        public DateTime? BankYe { get; set; }
        public int? BankPeriod { get; set; }
        public long BankId { get; set; }
        public string BankPosted { get; set; }
        public decimal? BankOurRef { get; set; }
    }
}
