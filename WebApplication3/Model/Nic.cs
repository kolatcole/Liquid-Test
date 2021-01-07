using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Nic
    {
        public long Id { get; set; }
        public string PeriodEnd { get; set; }
        public string WkNo { get; set; }
        public string Nictable { get; set; }
        public decimal AtLel { get; set; }
        public decimal LeltoEt { get; set; }
        public decimal EttoUel { get; set; }
        public decimal Both { get; set; }
        public decimal Emp { get; set; }
        public decimal? UaptoUel { get; set; }
    }
}
