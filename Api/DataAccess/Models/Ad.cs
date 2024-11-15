using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Ad
    {
        public int AdId { get; set; }
        public int UserId { get; set; }
        public int CarId { get; set; }
        public decimal Price { get; set; }
        public bool IsExchange { get; set; }
        public bool IsActive { get; set; }
        public DateTime PublishedDate { get; set; }

        public virtual Car Car { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
