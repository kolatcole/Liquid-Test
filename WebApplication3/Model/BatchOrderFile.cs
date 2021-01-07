using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class BatchOrderFile
    {
        public long Id { get; set; }
        public string GroupCode { get; set; }
        public string StockCode { get; set; }
        public int? OrderQty { get; set; }
        public decimal? Price { get; set; }
        public int? LineNo { get; set; }
        public string UserCode { get; set; }
        public string CustomerCode { get; set; }
    }
}
