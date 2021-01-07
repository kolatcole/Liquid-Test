﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class UserBankFeedDatum
    {
        public int Id { get; set; }
        public string ImportId { get; set; }
        public string BatchId { get; set; }
        public int UserBankId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal? PaidIn { get; set; }
        public decimal? Paidout { get; set; }
        public string Currency { get; set; }
        public string Type { get; set; }
        public string Nominal { get; set; }
        public string Vat { get; set; }
        public string Contact { get; set; }
        public bool? Processed { get; set; }
        public DateTime Addeddate { get; set; }
        public string Bank { get; set; }
    }
}
