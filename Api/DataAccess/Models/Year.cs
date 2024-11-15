using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Year
    {
        public Year()
        {
            Cars = new HashSet<Car>();
        }

        public int YearId { get; set; }
        public int Year1 { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
