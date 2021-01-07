using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class BankFeedTemplateHeader
    {
        public BankFeedTemplateHeader()
        {
            BankFeedData = new HashSet<BankFeedDatum>();
        }

        public int Id { get; set; }
        public string TemplateName { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Bank { get; set; }

        public virtual BankFeedColName BankFeedColName { get; set; }
        public virtual BankFeedTemplateDetail BankFeedTemplateDetail { get; set; }
        public virtual ICollection<BankFeedDatum> BankFeedData { get; set; }
    }
}
