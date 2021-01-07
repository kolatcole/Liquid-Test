using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class UserAccordion
    {
        public long Id { get; set; }
        public string UserCode { get; set; }
        public long? HeaderId { get; set; }
    }
}
