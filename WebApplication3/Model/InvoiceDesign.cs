using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class InvoiceDesign
    {
        public long Id { get; set; }
        public string Detail { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public int? LeftMargin { get; set; }
        public int? Height { get; set; }
        public bool? ShowCode { get; set; }
        public bool? ShowQty { get; set; }
        public bool? ShowPrice { get; set; }
        public bool? ShowVat { get; set; }
        public string Font { get; set; }
        public string FontSize { get; set; }
        public bool? ShowPacks { get; set; }
        public bool? ShowWeight { get; set; }
        public bool? ShowDetailBold { get; set; }
        public bool? ShowDelDate { get; set; }
        public bool? ShowBaseEquiv { get; set; }
        public bool? AlignBottom { get; set; }
        public bool? BorderAddress { get; set; }
        public bool? BorderHeader { get; set; }
        public bool? BorderDetail { get; set; }
        public bool? BorderTotal { get; set; }
        public string Cssstyle { get; set; }
    }
}
