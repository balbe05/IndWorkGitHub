using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class EngineCapacity
    {
        public EngineCapacity()
        {
            Cars = new HashSet<Car>();
        }

        public int EngineCapacityId { get; set; }
        public double EngineCapacity1 { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
