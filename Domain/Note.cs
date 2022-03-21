using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? EditTime { get; set; }
        public Tag[] Tags { get; set; }
    }
}
