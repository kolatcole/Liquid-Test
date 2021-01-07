using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class GoCardlessImportDatum
    {
        public string AccName { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string Currency { get; set; }
        public string Country { get; set; }
        public string Bic { get; set; }
        public string Iban { get; set; }
        public bool? AccountStatus { get; set; }
        public string AccountType { get; set; }
        public string BankReference { get; set; }
        public string AdditionalNarrative { get; set; }
        public string CustomerReference { get; set; }
        public string Trntype { get; set; }
        public DateTime? ValueDate { get; set; }
        public decimal? CreditAmount { get; set; }
        public decimal? DebitAmount { get; set; }
        public decimal? Balance { get; set; }
        public decimal? Posted { get; set; }
        public decimal? NotPosted { get; set; }
        public string Status { get; set; }
        public string ImportId { get; set; }
    }
}
