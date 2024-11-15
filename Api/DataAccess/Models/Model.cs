using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Model
    {
        public Model()
        {
            Cars = new HashSet<Car>();
        }

        public int ModelId { get; set; }
        public string ModelName { get; set; } = null!;
        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; } = null!;
        public virtual ICollection<Car> Cars { get; set; }
    }
}
