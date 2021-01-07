using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Order
    {
        public long NltKey { get; set; }
        public string NlCode { get; set; }
        public string NlCo { get; set; }
        public DateTime? NltDate { get; set; }
        public int? NltPeriod { get; set; }
        public DateTime? NltYearEnd { get; set; }
        public string NltSource { get; set; }
        public string NltRef { get; set; }
        public string NltDetail { get; set; }
        public decimal? NltNet { get; set; }
        public decimal? NltVat { get; set; }
        public string NltVatCode { get; set; }
        public string NltReturn { get; set; }
        public string NltDept { get; set; }
        public decimal? NltPaid { get; set; }
        public string NltPaidRef { get; set; }
        public string NltCosting { get; set; }
        public string NltAudit { get; set; }
        public int? NltRecon { get; set; }
        public string NltOnlyFlag { get; set; }
        public string NltEnteredBy { get; set; }
        public string NltEnteredDate { get; set; }
        public string NltEnteredTime { get; set; }
        public string NltStockCode { get; set; }
        public double? NltPacks { get; set; }
        public double? NltQty { get; set; }
        public decimal? NltPrice { get; set; }
        public string NltInvNo { get; set; }
        public int? NltLineNo { get; set; }
        public string NltTheirRef { get; set; }
        public decimal? NltToPay { get; set; }
        public string NltInvoicedNo { get; set; }
        public double? NltInvoicedQty { get; set; }
        public string NltDelAdd { get; set; }
        public bool? NltCompleted { get; set; }
    }
}
