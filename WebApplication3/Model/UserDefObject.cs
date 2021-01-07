using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class UserDefObject
    {
        public long Id { get; set; }
        public string ProgName { get; set; }
        public string Container { get; set; }
        public string ObjectName { get; set; }
        public string UserName { get; set; }
    }
}
