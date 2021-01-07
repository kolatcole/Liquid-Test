using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class BankFeedColName
    {
        public int TemplateId { get; set; }
        public string ColNames { get; set; }

        public virtual BankFeedTemplateHeader Template { get; set; }
    }
}
