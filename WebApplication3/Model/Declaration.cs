using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Declaration
    {
        public long Id { get; set; }
        public DateTime? FinalDeclaration { get; set; }
        public string LastFps { get; set; }
        public string YearEnd { get; set; }
        public string FreeOfTax { get; set; }
        public string ExpenseVouchers { get; set; }
        public string OutsideUk { get; set; }
        public string PaySomeoneElse { get; set; }
        public string P11dforms { get; set; }
        public string ServiceCompany { get; set; }
    }
}
