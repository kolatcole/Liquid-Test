using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Stock
    {
        public Stock()
        {
            Bomcomponents = new HashSet<Bomcomponent>();
            BommanufactureComponents = new HashSet<BommanufactureComponent>();
            LocationStocks = new HashSet<LocationStock>();
        }

        public string StCode { get; set; }
        public string StDescription { get; set; }
        public string StIntStatCode { get; set; }
        public string StWeight { get; set; }
        public decimal? StSalePrice { get; set; }
        public decimal? StCostPrice { get; set; }
        public string StNotes { get; set; }
        public string StNomAcct { get; set; }
        public string StDeptCode { get; set; }
        public decimal? StInStock { get; set; }
        public decimal? StOnOrder { get; set; }
        public decimal? StAllocated { get; set; }
        public decimal? StMinLevel { get; set; }
        public string StCompany { get; set; }
        public string StLocation { get; set; }
        public string StHold { get; set; }
        public string StVatOver { get; set; }
        public string StNoTrans { get; set; }
        public string StProdGroup { get; set; }
        public string StImageFile1 { get; set; }
        public string StImageFile2 { get; set; }
        public string StExcFromWeb { get; set; }
        public DateTime? StLastUpdated { get; set; }
        public int? StUnitsPerPallet { get; set; }
        public decimal? Rhd { get; set; }
        public decimal? StorageCost { get; set; }
        public DateTime? StoredFromDate { get; set; }
        public string StDefaultLocation { get; set; }
        public long Id { get; set; }
        public bool? ExclReports { get; set; }
        public string Barcode { get; set; }
        public string SalesCode { get; set; }
        public string PurchaseCode { get; set; }
        public string SalesVatcode { get; set; }
        public string PurchaseVatcode { get; set; }
        public DateTime? LastAmended { get; set; }
        public decimal? TradePrice { get; set; }
        public decimal? PackPrice { get; set; }
        public decimal? CartonPrice { get; set; }
        public string EntityId { get; set; }
        public DateTime? CostPriceLastUpdate { get; set; }
        public string SaleCurrCode { get; set; }
        public string PurCurrCode { get; set; }
        public string ValuationBasis { get; set; }
        public bool? IsBom { get; set; }
        public bool IsTrackable { get; set; }
        public bool? IsService { get; set; }
        public string StCountry { get; set; }
        public string StHscode { get; set; }

        public virtual ICollection<Bomcomponent> Bomcomponents { get; set; }
        public virtual ICollection<BommanufactureComponent> BommanufactureComponents { get; set; }
        public virtual ICollection<LocationStock> LocationStocks { get; set; }
    }
}
