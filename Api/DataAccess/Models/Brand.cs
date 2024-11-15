using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Cars = new HashSet<Car>();
            Models = new HashSet<Model>();
        }

        public int BrandId { get; set; }
        public string BrandName { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<Model> Models { get; set; }
    }
}
