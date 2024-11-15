using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public int FromUserId { get; set; }
        public int ToUserId { get; set; }
        public string ReviewRext { get; set; } = null!;
        public int Mark { get; set; }
        public int AdId { get; set; }

        public virtual User FromUser { get; set; } = null!;
        public virtual User ToUser { get; set; } = null!;
    }
}
