using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class UserBankAcct
    {
        public int BankId { get; set; }
        public string BankName { get; set; }
        public string CurrCode { get; set; }
        public string AccountNumber { get; set; }
        public int UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
