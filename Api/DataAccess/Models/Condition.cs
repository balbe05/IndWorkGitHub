using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Condition
    {
        public Condition()
        {
            Cars = new HashSet<Car>();
        }

        public int ConditionId { get; set; }
        public string ConditionName { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; }
    }
}
