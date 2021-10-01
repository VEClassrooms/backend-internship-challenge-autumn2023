using System;

namespace web.Backend.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public DateTime UploadedDate { get; set; }
        public User UploadedBy { get; set; }
    }
}