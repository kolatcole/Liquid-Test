using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class ContactAppSupp
    {
        public long Id { get; set; }
        public long? ContactId { get; set; }
        public long? ApprovedSupp { get; set; }
    }
}
