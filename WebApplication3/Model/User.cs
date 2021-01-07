using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class User
    {
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserLocale { get; set; }
        public string LwDefaultCo { get; set; }
        public string LwDefaultCoName { get; set; }
        public string LwDefaultCoExt { get; set; }
    }
}
