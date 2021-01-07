using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class StockType
    {
        public string StTypeCode { get; set; }
        public string StTypeDesc { get; set; }
        public string StTypeSaleCode { get; set; }
        public string StTypePurchCode { get; set; }
        public bool IsTrackable { get; set; }
    }
}
