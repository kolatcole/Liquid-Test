using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class StockSupplier
    {
        public long Id { get; set; }
        public string StockId { get; set; }
        public long? SuppId { get; set; }
        public decimal? Price { get; set; }
        public DateTime? Date { get; set; }
        public string SuppRef { get; set; }
        public decimal? MinOrder { get; set; }
    }
}
