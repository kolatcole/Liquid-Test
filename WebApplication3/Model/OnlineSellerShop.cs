using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class OnlineSellerShop
    {
        public string Code { get; set; }
        public string Oscode { get; set; }
        public string ShopName { get; set; }
        public string ShopEmail { get; set; }
        public string ShopPwd { get; set; }
        public string AppName { get; set; }
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
        public string ApiToken { get; set; }
        public string DevId { get; set; }
        public string DevPwd { get; set; }
        public string DevToken { get; set; }
        public string DevEmail { get; set; }
        public string Url { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public bool? Status { get; set; }
        public string OrderInterval { get; set; }
        public DateTime? StartRunDateTime { get; set; }
        public string Notes { get; set; }
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public string NominalCode { get; set; }

        public virtual OnlineSeller OscodeNavigation { get; set; }
    }
}
