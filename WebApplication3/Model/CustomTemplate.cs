using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class CustomTemplate
    {
        public int Id { get; set; }
        public string TemplatePage { get; set; }
        public string TemplateDescription { get; set; }
        public string TemplateLogo { get; set; }
    }
}
