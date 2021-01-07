using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Grn
    {
        public long Id { get; set; }
        public string Pon { get; set; }
        public int? Ponline { get; set; }
        public string Code { get; set; }
        public string ProductFormat { get; set; }
        public string PackType { get; set; }
        public string ProductType { get; set; }
        public string ProdDescription { get; set; }
        public decimal? PackQty { get; set; }
        public DateTime? DateRecd { get; set; }
        public decimal? Packs { get; set; }
        public decimal? TotalQty { get; set; }
        public string SuppBatchNo { get; set; }
        public string CountryOrigin { get; set; }
        public DateTime? DateProduced { get; set; }
        public DateTime? BestBefore { get; set; }
        public decimal? Brix { get; set; }
        public decimal? Acidity { get; set; }
        public decimal? RecdTemp { get; set; }
        public string Location { get; set; }
        public string BinNo { get; set; }
        public string Currency { get; set; }
        public decimal? Fxrate { get; set; }
        public decimal? PriceCurr { get; set; }
        public decimal? Transport { get; set; }
        public decimal? Rhd { get; set; }
        public decimal? PackCost { get; set; }
        public decimal? TotalCost { get; set; }
        public string Notes { get; set; }
        public string ScannedCofA { get; set; }
        public string ScannedPhoto { get; set; }
        public string Query { get; set; }
        public bool? Quarantined { get; set; }
        public short? Status { get; set; }
        public decimal? Duty { get; set; }
        public string Ph { get; set; }
        public decimal? AddCosts { get; set; }
        public bool? Archive { get; set; }
    }
}
