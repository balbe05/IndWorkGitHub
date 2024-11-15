using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class SteeringWheelLocation
    {
        public SteeringWheelLocation()
        {
            Cars = new HashSet<Car>();
        }

        public int SteeringWheelLocationId { get; set; }
        public string SteeringWheelLocationName { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; }
    }
}
