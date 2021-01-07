using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class P11
    {
        public long Id { get; set; }
        public string P11TaxYear { get; set; }
        public string P11Employee { get; set; }
        public string P11Year { get; set; }
        public string P11MonthWeek { get; set; }
        public int? P11Period { get; set; }
        public DateTime? P11Date { get; set; }
        public decimal? P11GrossPay { get; set; }
        public decimal? P11TaxableGross { get; set; }
        public decimal? P11FreePay { get; set; }
        public decimal? P11Taxable { get; set; }
        public decimal? P11Tax { get; set; }
        public decimal? P11StdNi { get; set; }
        public decimal? P11EeNi { get; set; }
        public decimal? P11ErNi { get; set; }
        public int? P11Posted { get; set; }
        public string P11TaxCode { get; set; }
        public string P11NiCode { get; set; }
        public string P11Temp { get; set; }
        public string P11Dept { get; set; }
        public string P11Company { get; set; }
        public decimal? P11Ssp { get; set; }
        public decimal? P11Spp { get; set; }
        public decimal? P11Smp { get; set; }
        public decimal? P11Sap { get; set; }
        public decimal? P11Sld { get; set; }
        public decimal? P11Tc { get; set; }
        public decimal? Lel { get; set; }
        public decimal? Et { get; set; }
        public decimal? Uap { get; set; }
        public decimal? Uel { get; set; }
        public decimal? ErContValue { get; set; }
        public string ErContCharge { get; set; }
        public string ErContCredit { get; set; }
        public DateTime? Fps { get; set; }
    }
}
