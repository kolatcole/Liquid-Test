using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3
{
    public class Transactions
    {
        public Transactions()
        { }

        public int NLT_LineNo { get; set; }
        public String NLT_StockCode { get; set; }
        public String NLT_Detail { get; set; }
        public Double NLT_Packs { get; set; }
        public Double NLT_Units { get; set; }
        public Double NLT_Qty { get; set; }
        public Double NLT_Price { get; set; }
        public Double NLT_Net { get; set; }
        public String NLT_VAT_Code { get; set; }
        public Double NLT_VAT { get; set; }
        public String NL_Code { get; set; }
        public Double NLT_Paid { get; set; }
        public String NLT_Ref { get; set; }
        public String NLT_Source { get; set; }
        public String NLT_Audit { get; set; }
        public Double NLT_CurrNet { get; set; }
        public Double NLT_CurrVAT { get; set; }
        public String NLT_InvNo { get; set; }
        public String NLT_Location { get; set; }
        public DateTime NLT_YearEnd { get; set; }
        public int NLT_Period { get; set; }
        public String NLT_Costing { get; set; }
        public String DR_Control { get; set; }
        public String CR_Control { get; set; }
        public String VAT_Control { get; set; }
    }


    public class InputData
    {
        public string stock { get; set; }

        public string disc { get; set; }
        public string detail { get; set; }

        public string quantity { get; set; }

        public string price { get; set; }

        public string vatcode { get; set; }

        public string vat { get; set; }

        public string net { get; set; }

        public string nominal { get; set; }
        public string costing { get; set; }
        public string location { get; set; }
        public string packsize { get; set; }
        public string exrate { get; set; }
        public int intPeriod { get; set; }

        public string invNo { get; set; }

        public string DRControl { get; set; }
        public string VATControl { get; set; }

        public string Ref { get; set; }

        public string Source { get; set; }

        public double lineDisc { get; set; }

        public string currency { get; set; }

        public string orderNo { get; set; }

        public string deliveryAdd { get; set; }
        public string invRef { get; set; }

        public string enteredBy { get; set; }

        public string notes { get; set; }

        public string description { get; set; }
        public string TrackingNumber { get; set; }

        public bool chkIsSerial { get; set; }

        public int TrackingTypeID { get; set; }

        public string LocationCode { get; set; }

        public string NlCode { get; set; }









    }
}
