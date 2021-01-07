using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Mapping
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string ColName { get; set; }
        public string MapTo { get; set; }
    }
}
