using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class BankFeedTemplateDetail
    {
        public int TemplateId { get; set; }
        public string TransactionDate { get; set; }
        public string Reference { get; set; }
        public string PaidIn { get; set; }
        public string PaidOut { get; set; }
        public string DebitCredit { get; set; }

        public virtual BankFeedTemplateHeader Template { get; set; }
    }
}
