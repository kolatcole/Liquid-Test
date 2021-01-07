using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class RelatedContact
    {
        public long RelatedContactId { get; set; }
        public long Id { get; set; }
        public long FriendId { get; set; }
        public string Text { get; set; }
        public DateTime? LastContact { get; set; }
        public string Strength { get; set; }
    }
}
