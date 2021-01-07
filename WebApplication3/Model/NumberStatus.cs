using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class NumberStatus
    {
        public NumberStatus()
        {
            BatchNumbers = new HashSet<BatchNumber>();
            SerialNumbers = new HashSet<SerialNumber>();
        }

        public int StatusId { get; set; }
        public string Status { get; set; }

        public virtual ICollection<BatchNumber> BatchNumbers { get; set; }
        public virtual ICollection<SerialNumber> SerialNumbers { get; set; }
    }
}
