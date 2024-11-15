using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class DriveType
    {
        public DriveType()
        {
            Cars = new HashSet<Car>();
        }

        public int DriveTypeId { get; set; }
        public string DriveTypeName { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; }
    }
}
