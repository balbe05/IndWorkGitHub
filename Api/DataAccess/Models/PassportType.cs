using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class PassportType
    {
        public PassportType()
        {
            Cars = new HashSet<Car>();
        }

        public int PassportTypeId { get; set; }
        public string PassportTypeName { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; }
    }
}
