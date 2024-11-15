using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class User
    {
        public User()
        {
            Ads = new HashSet<Ad>();
            Favorites = new HashSet<Favorite>();
            MessageReceivers = new HashSet<Message>();
            MessageSenders = new HashSet<Message>();
            ReviewFromUsers = new HashSet<Review>();
            ReviewToUsers = new HashSet<Review>();
        }

        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string? Email { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public DateTime RegistrarionDate { get; set; }
        public DateTime LastLoginDatetime { get; set; }
        public bool IsActive { get; set; }
        public int RegionId { get; set; }
        public int? CityId { get; set; }

        public virtual City? City { get; set; }
        public virtual Region Region { get; set; } = null!;
        public virtual ICollection<Ad> Ads { get; set; }
        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<Message> MessageReceivers { get; set; }
        public virtual ICollection<Message> MessageSenders { get; set; }
        public virtual ICollection<Review> ReviewFromUsers { get; set; }
        public virtual ICollection<Review> ReviewToUsers { get; set; }
    }
}
