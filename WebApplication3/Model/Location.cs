using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Location
    {
        public Location()
        {
            Bomitems = new HashSet<Bomitem>();
            Bommanufactures = new HashSet<Bommanufacture>();
            LocationStocks = new HashSet<LocationStock>();
            StockTrackings = new HashSet<StockTracking>();
        }

        public string Code { get; set; }
        public string Detail { get; set; }
        public decimal? Rhd { get; set; }
        public decimal? Storage { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public int? ManagerId { get; set; }
        public int? TypeId { get; set; }
        public bool? IsActive { get; set; }

        public virtual LuLocationType Type { get; set; }
        public virtual ICollection<Bomitem> Bomitems { get; set; }
        public virtual ICollection<Bommanufacture> Bommanufactures { get; set; }
        public virtual ICollection<LocationStock> LocationStocks { get; set; }
        public virtual ICollection<StockTracking> StockTrackings { get; set; }
    }
}
