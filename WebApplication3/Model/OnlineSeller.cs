using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class OnlineSeller
    {
        public OnlineSeller()
        {
            OnlineSellerShops = new HashSet<OnlineSellerShop>();
        }

        public string Oscode { get; set; }
        public string Osname { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<OnlineSellerShop> OnlineSellerShops { get; set; }
    }
}
