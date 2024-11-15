using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class EngineType
    {
        public EngineType()
        {
            Cars = new HashSet<Car>();
        }

        public int EngineTypeId { get; set; }
        public string EngineTypeName { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; }
    }
}
