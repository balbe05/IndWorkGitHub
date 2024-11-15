using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Favorite
    {
        public int FavoriteId { get; set; }
        public int UserId { get; set; }
        public int AdId { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
