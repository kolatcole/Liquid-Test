using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class CustProduct
    {
        public long Id { get; set; }
        public long? CustKey { get; set; }
        public string Product { get; set; }
    }
}
