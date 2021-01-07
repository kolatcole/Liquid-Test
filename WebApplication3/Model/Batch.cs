﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Batch
    {
        public long Id { get; set; }
        public string UserCode { get; set; }
        public string Ledger { get; set; }
        public string Acct { get; set; }
        public DateTime? Date { get; set; }
        public string OurInvNo { get; set; }
        public string TheirRef { get; set; }
        public string Detail { get; set; }
        public decimal? Net { get; set; }
        public decimal? Vat { get; set; }
        public string Vatcode { get; set; }
        public bool? Posted { get; set; }
        public DateTime? SettleDate { get; set; }
        public string BatchId { get; set; }
        public string Costing { get; set; }
        public DateTime? DelivlDate { get; set; }
        public decimal? Qty { get; set; }
        public float? ExchRate { get; set; }
        public decimal? Price { get; set; }
        public string Notes { get; set; }
        public string CurrCode { get; set; }
        public decimal? CurrNet { get; set; }
        public decimal? CurrVat { get; set; }
        public decimal? Total { get; set; }
    }
}
