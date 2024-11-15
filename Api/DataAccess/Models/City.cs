using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class City
    {
        public City()
        {
            Users = new HashSet<User>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; } = null!;
        public int RegionId { get; set; }

        public virtual Region Region { get; set; } = null!;
        public virtual ICollection<User> Users { get; set; }
    }
}
