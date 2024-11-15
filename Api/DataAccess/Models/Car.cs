using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Car
    {
        public Car()
        {
            Ads = new HashSet<Ad>();
            Photos = new HashSet<Photo>();
        }

        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public int Milleage { get; set; }
        public int YearId { get; set; }
        public int ColorId { get; set; }
        public int EngineTypeId { get; set; }
        public int TransmissionId { get; set; }
        public int DriveTypeId { get; set; }
        public int ConditionId { get; set; }
        public string VinNumber { get; set; } = null!;
        public int EngineCapacityId { get; set; }
        public bool ClearedByCustoms { get; set; }
        public bool Broken { get; set; }
        public string RegistrationCertificate { get; set; } = null!;
        public int SteeringWheelLocationId { get; set; }
        public decimal FuelConsumption { get; set; }
        public string CarNumber { get; set; } = null!;
        public int OwnersNumber { get; set; }
        public int PassportTypeId { get; set; }

        public virtual Brand Brand { get; set; } = null!;
        public virtual Color Color { get; set; } = null!;
        public virtual Condition Condition { get; set; } = null!;
        public virtual DriveType DriveType { get; set; } = null!;
        public virtual EngineCapacity EngineCapacity { get; set; } = null!;
        public virtual EngineType EngineType { get; set; } = null!;
        public virtual Model Model { get; set; } = null!;
        public virtual PassportType PassportType { get; set; } = null!;
        public virtual SteeringWheelLocation SteeringWheelLocation { get; set; } = null!;
        public virtual Transmission Transmission { get; set; } = null!;
        public virtual Year Year { get; set; } = null!;
        public virtual ICollection<Ad> Ads { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
