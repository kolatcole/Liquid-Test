using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class GroupMember
    {
        public long GroupMemberId { get; set; }
        public long Id { get; set; }
        public long GroupId { get; set; }
    }
}
