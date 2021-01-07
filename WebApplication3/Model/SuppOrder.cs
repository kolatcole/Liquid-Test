using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class SuppOrder
    {
        public long SuppOrderKey { get; set; }
        public string SuppCode { get; set; }
        public decimal? OrderNo { get; set; }
        public int? OrderLine { get; set; }
        public string CoAddress { get; set; }
        public string DelAdd { get; set; }
        public string SuppOrderNo { get; set; }
        public DateTime? DateOfQuote { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string Salesman { get; set; }
        public string Notes { get; set; }
        public string StkCode { get; set; }
        public string Detail { get; set; }
        public decimal? PackSize { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Weight { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? CostPrice { get; set; }
        public string Vatcode { get; set; }
        public decimal? Vat { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? EntryDate { get; set; }
        public decimal? CostPriceCurr { get; set; }
        public decimal? Vatcurr { get; set; }
        public decimal? ExchRate { get; set; }
        public string CurrCode { get; set; }
        public decimal? Delivered { get; set; }
        public string Backorder { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public string NomCode { get; set; }
        public string CostCode { get; set; }
        public string SaleOrderNo { get; set; }
        public long? Grnno { get; set; }
        public string DispatchStatus { get; set; }
        public string MailStatus { get; set; }
        public string PicklistStatus { get; set; }
        public string ContractNo { get; set; }
        public string EmailFrom { get; set; }
        public DateTime? EmailSent { get; set; }
        public decimal? LineDiscount { get; set; }
    }
}
