using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class PayrollJournal
    {
        public long Id { get; set; }
        public long PayrollId { get; set; }
        public string TaxYear { get; set; }
        public string MonthWeek { get; set; }
        public int Period { get; set; }
        public DateTime PayDate { get; set; }
        public string NomCode { get; set; }
        public string DisplayName { get; set; }
        public decimal Value { get; set; }
        public bool CreditEntry { get; set; }
        public string Costing { get; set; }
        public DateTime? DtimeStamp { get; set; }
    }
}
