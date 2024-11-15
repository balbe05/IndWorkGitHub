using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Transmission
    {
        public Transmission()
        {
            Cars = new HashSet<Car>();
        }

        public int TransmissionId { get; set; }
        public string TransmissionName { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; }
    }
}
