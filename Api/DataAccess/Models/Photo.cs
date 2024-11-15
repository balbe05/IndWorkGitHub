using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Photo
    {
        public int PhotoId { get; set; }
        public int CarId { get; set; }
        public string PhotoUrl { get; set; } = null!;
        public bool IsMain { get; set; }

        public virtual Car Car { get; set; } = null!;
    }
}
