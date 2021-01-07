using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class SelectOption
    {
        public long SoKey { get; set; }
        public string SoCode { get; set; }
        public int? SoOrder { get; set; }
        public string SoValue { get; set; }
        public string SoOption { get; set; }
    }
}
