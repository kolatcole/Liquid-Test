using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class SaleOrder
    {
        public long QuoteKey { get; set; }
        public string CustCode { get; set; }
        public decimal? QuoteNo { get; set; }
        public int? QuoteLine { get; set; }
        public string CoAddress { get; set; }
        public string DelAdd { get; set; }
        public string CustOrderNo { get; set; }
        public DateTime? DateOfQuote { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string Salesman { get; set; }
        public string Notes { get; set; }
        public string StkCode { get; set; }
        public string Detail { get; set; }
        public decimal? Qty { get; set; }
        public decimal? PackSize { get; set; }
        public decimal? Weight { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? SellPrice { get; set; }
        public string Vatcode { get; set; }
        public decimal? Vat { get; set; }
        public decimal? CostPrice { get; set; }
        public string Status { get; set; }
        public string SuppCode { get; set; }
        public string Location { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? EntryDate { get; set; }
        public decimal? SellPriceCurr { get; set; }
        public decimal? Vatcurr { get; set; }
        public decimal? CostPriceCurr { get; set; }
        public decimal? ExchRate { get; set; }
        public string CurrCode { get; set; }
        public string Costing { get; set; }
        public string Qostatus { get; set; }
        public string Nominal { get; set; }
        public string BatchId { get; set; }
        public DateTime? DispatchDate { get; set; }
        public decimal? LineDiscount { get; set; }
        public string PicklistStatus { get; set; }
        public string MailStatus { get; set; }
        public string DispatchStatus { get; set; }
        public string ShippingInfo { get; set; }
        public string ContractNo { get; set; }
        public bool? StoreApproved { get; set; }
        public string ConsignmentNo { get; set; }
        public string EmailFrom { get; set; }
        public decimal? Invoiced { get; set; }
        public DateTime? EmailSent { get; set; }
        public bool? ExclFromPrint { get; set; }
    }
}
