using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class Employee
    {
        public long Id { get; set; }
        public string EeCode { get; set; }
        public string EeSurname { get; set; }
        public string EeFirstName { get; set; }
        public string EeAdd1 { get; set; }
        public string EeAdd2 { get; set; }
        public string EeAdd3 { get; set; }
        public string EePostCode { get; set; }
        public string EePhone { get; set; }
        public string EeNiNo { get; set; }
        public DateTime? EeDob { get; set; }
        public string EeNiTable { get; set; }
        public string EeSex { get; set; }
        public DateTime? EeDateStart { get; set; }
        public DateTime? EeDateLeft { get; set; }
        public double? EeChargeRate { get; set; }
        public string EePayFrequency { get; set; }
        public string EePayNo { get; set; }
        public string EePayType { get; set; }
        public double? EeNetPay { get; set; }
        public string EeTaxCode { get; set; }
        public double? EeGrossToDate { get; set; }
        public double? EeTaxToDate { get; set; }
        public string EeBankName { get; set; }
        public string EeBranchAdd1 { get; set; }
        public string EeBranchAdd2 { get; set; }
        public string EeAccount { get; set; }
        public string EeAcctNo { get; set; }
        public string EeRollNo { get; set; }
        public string EeSortCode { get; set; }
        public double? EePrevTaxable { get; set; }
        public double? EePrevTax { get; set; }
        public string EeNomGross { get; set; }
        public string EeNomNic { get; set; }
        public string EeDept { get; set; }
        public string EeCompany { get; set; }
        public int? EeDirector { get; set; }
        public DateTime? EeAppointDir { get; set; }
        public bool? EeSspMon { get; set; }
        public bool? EeSspTue { get; set; }
        public bool? EeSspWed { get; set; }
        public bool? EeSspThu { get; set; }
        public bool? EeSspFri { get; set; }
        public bool? EeSspSat { get; set; }
        public bool? EeSspSun { get; set; }
        public string EeOldCode { get; set; }
        public string EeOldCo { get; set; }
        public int? EeStudentLoan { get; set; }
        public string EePayCode { get; set; }
        public int? EeSecCode { get; set; }
        public string EeTaxComments { get; set; }
        public string EeEmail { get; set; }
        public bool? Salesman { get; set; }
        public string UserCode { get; set; }
        public string StartDec { get; set; }
        public string OtherPayType { get; set; }
        public string PassportNo { get; set; }
        public bool? ForceFps { get; set; }
    }
}
