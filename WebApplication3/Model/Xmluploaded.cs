using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Xmluploaded
    {
        public long Id { get; set; }
        public DateTime? Date { get; set; }
        public string Xmltext { get; set; }
        public string Error { get; set; }
    }
}
