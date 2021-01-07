using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication3.Model
{
    public partial class UploadedFile
    {
        public long Id { get; set; }
        public string FileName { get; set; }
        public string Comments { get; set; }
        public DateTime? DateUploaded { get; set; }
        public bool? Completed { get; set; }
        public DateTime? DateCompleted { get; set; }
        public string FileType { get; set; }
    }
}
