using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class AssociateContact
    {
        public long Id { get; set; }
        public long? AddContactId { get; set; }
        public long? CompanyId { get; set; }
    }
}
