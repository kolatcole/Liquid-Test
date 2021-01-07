using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class PayErCont
    {
        public long Id { get; set; }
        public string EeCode { get; set; }
        public string ErContCharge { get; set; }
        public string ErContCr { get; set; }
        public decimal? ErContValue { get; set; }
    }
}
