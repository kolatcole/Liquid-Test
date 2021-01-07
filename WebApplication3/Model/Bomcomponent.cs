using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Bomcomponent
    {
        public int BomcomponentId { get; set; }
        public string Bomcode { get; set; }
        public string ComponentCode { get; set; }
        public bool? IsBom { get; set; }
        public double ComponentQty { get; set; }
        public int BomstatusId { get; set; }
        public double Bomcost { get; set; }

        public virtual Bomitem BomcodeNavigation { get; set; }
        public virtual Bomstatus Bomstatus { get; set; }
        public virtual Stock ComponentCodeNavigation { get; set; }
    }
}
