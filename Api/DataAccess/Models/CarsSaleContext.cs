using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess.Models
{
    public partial class CarsSaleContext : DbContext
    {
        public CarsSaleContext()
        {
        }

        public CarsSaleContext(DbContextOptions<CarsSaleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ad> Ads { get; set; } = null!;
        public virtual DbSet<Brand> Brands { get; set; } = null!;
        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Color> Colors { get; set; } = null!;
        public virtual DbSet<Condition> Conditions { get; set; } = null!;
        public virtual DbSet<DriveType> DriveTypes { get; set; } = null!;
        public virtual DbSet<EngineCapacity> EngineCapacities { get; set; } = null!;
        public virtual DbSet<EngineType> EngineTypes { get; set; } = null!;
        public virtual DbSet<Favorite> Favorites { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;
        public virtual DbSet<Model> Models { get; set; } = null!;
        public virtual DbSet<PassportType> PassportTypes { get; set; } = null!;
        public virtual DbSet<Photo> Photos { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;
        public virtual DbSet<Review> Reviews { get; set; } = null!;
        public virtual DbSet<SteeringWheelLocation> SteeringWheelLocations { get; set; } = null!;
        public virtual DbSet<Transmission> Transmissions { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Year> Years { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ad>(entity =>
            {
                entity.Property(e => e.AdId).HasColumnName("ad_id");

                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsExchange).HasColumnName("is_exchange");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PublishedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("published_date");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Ads)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ads_Cars");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Ads)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ads_Users");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.Property(e => e.BrandId).HasColumnName("brand_id");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(20)
                    .HasColumnName("brand_name");
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.Property(e => e.BrandId).HasColumnName("brand_id");

                entity.Property(e => e.Broken).HasColumnName("broken");

                entity.Property(e => e.CarNumber)
                    .HasMaxLength(10)
                    .HasColumnName("car_number");

                entity.Property(e => e.ClearedByCustoms).HasColumnName("cleared_by_customs");

                entity.Property(e => e.ColorId).HasColumnName("color_id");

                entity.Property(e => e.ConditionId).HasColumnName("condition_id");

                entity.Property(e => e.DriveTypeId).HasColumnName("drive_type_id");

                entity.Property(e => e.EngineCapacityId).HasColumnName("engine_capacity_id");

                entity.Property(e => e.EngineTypeId).HasColumnName("engine_type_id");

                entity.Property(e => e.FuelConsumption)
                    .HasColumnType("decimal(2, 2)")
                    .HasColumnName("fuel_consumption");

                entity.Property(e => e.Milleage).HasColumnName("milleage");

                entity.Property(e => e.ModelId).HasColumnName("model_id");

                entity.Property(e => e.OwnersNumber).HasColumnName("owners_number");

                entity.Property(e => e.PassportTypeId).HasColumnName("passport_type_id");

                entity.Property(e => e.RegistrationCertificate)
                    .HasMaxLength(20)
                    .HasColumnName("registration_certificate");

                entity.Property(e => e.SteeringWheelLocationId).HasColumnName("steering_wheel_location_id");

                entity.Property(e => e.TransmissionId).HasColumnName("transmission_id");

                entity.Property(e => e.VinNumber)
                    .HasMaxLength(50)
                    .HasColumnName("VIN_number");

                entity.Property(e => e.YearId).HasColumnName("year_id");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cars_Brands");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.ColorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cars_Colors");

                entity.HasOne(d => d.Condition)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.ConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cars_Conditions");

                entity.HasOne(d => d.DriveType)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.DriveTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cars_Drive_types");

                entity.HasOne(d => d.EngineCapacity)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.EngineCapacityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cars_engine_capacities");

                entity.HasOne(d => d.EngineType)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.EngineTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cars_Engine_types");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.ModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cars_Models");

                entity.HasOne(d => d.PassportType)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.PassportTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cars_Passport_types");

                entity.HasOne(d => d.SteeringWheelLocation)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.SteeringWheelLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cars_Steering_wheel_locations");

                entity.HasOne(d => d.Transmission)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.TransmissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cars_Transmissions");

                entity.HasOne(d => d.Year)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.YearId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cars_Years");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .HasColumnName("city_name");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cities_Regions");
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.Property(e => e.ColorId).HasColumnName("color_id");

                entity.Property(e => e.ColorName)
                    .HasMaxLength(50)
                    .HasColumnName("color_name");
            });

            modelBuilder.Entity<Condition>(entity =>
            {
                entity.Property(e => e.ConditionId).HasColumnName("condition_id");

                entity.Property(e => e.ConditionName)
                    .HasMaxLength(50)
                    .HasColumnName("condition_name");
            });

            modelBuilder.Entity<DriveType>(entity =>
            {
                entity.ToTable("Drive_types");

                entity.Property(e => e.DriveTypeId).HasColumnName("drive_type_id");

                entity.Property(e => e.DriveTypeName)
                    .HasMaxLength(50)
                    .HasColumnName("drive_type_name");
            });

            modelBuilder.Entity<EngineCapacity>(entity =>
            {
                entity.ToTable("Engine_capacities");

                entity.Property(e => e.EngineCapacityId).HasColumnName("engine_capacity_id");

                entity.Property(e => e.EngineCapacity1).HasColumnName("engine_capacity");
            });

            modelBuilder.Entity<EngineType>(entity =>
            {
                entity.ToTable("Engine_types");

                entity.Property(e => e.EngineTypeId).HasColumnName("engine_type_id");

                entity.Property(e => e.EngineTypeName)
                    .HasMaxLength(50)
                    .HasColumnName("engine_type_name");
            });

            modelBuilder.Entity<Favorite>(entity =>
            {
                entity.Property(e => e.FavoriteId).HasColumnName("favorite_id");

                entity.Property(e => e.AdId).HasColumnName("ad_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Favorites)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Favorites_Users");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.MessageId).HasColumnName("message_id");

                entity.Property(e => e.AdId).HasColumnName("ad_id");

                entity.Property(e => e.IsRead)
                    .HasMaxLength(10)
                    .HasColumnName("is_read")
                    .IsFixedLength();

                entity.Property(e => e.MessageText)
                    .HasColumnType("text")
                    .HasColumnName("message_text");

                entity.Property(e => e.ReceiverId).HasColumnName("receiver_id");

                entity.Property(e => e.SenderId).HasColumnName("sender_id");

                entity.Property(e => e.SentAt)
                    .HasColumnType("datetime")
                    .HasColumnName("sent_at");

                entity.HasOne(d => d.Receiver)
                    .WithMany(p => p.MessageReceivers)
                    .HasForeignKey(d => d.ReceiverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Messages_Users1");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.MessageSenders)
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Messages_Users");
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.Property(e => e.ModelId).HasColumnName("model_id");

                entity.Property(e => e.BrandId).HasColumnName("brand_id");

                entity.Property(e => e.ModelName)
                    .HasMaxLength(50)
                    .HasColumnName("model_name");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Models)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Models_Brands");
            });

            modelBuilder.Entity<PassportType>(entity =>
            {
                entity.ToTable("Passport_types");

                entity.Property(e => e.PassportTypeId).HasColumnName("passport_type_id");

                entity.Property(e => e.PassportTypeName)
                    .HasMaxLength(50)
                    .HasColumnName("passport_type_name");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.Property(e => e.PhotoId).HasColumnName("photo_id");

                entity.Property(e => e.CarId).HasColumnName("car_id");

                entity.Property(e => e.IsMain).HasColumnName("is_main");

                entity.Property(e => e.PhotoUrl)
                    .HasMaxLength(255)
                    .HasColumnName("photo_url");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Photos)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photos_Cars");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.RegionName)
                    .HasMaxLength(50)
                    .HasColumnName("region_name");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.Property(e => e.ReviewId).HasColumnName("review_id");

                entity.Property(e => e.AdId).HasColumnName("ad_id");

                entity.Property(e => e.FromUserId).HasColumnName("from_user_id");

                entity.Property(e => e.Mark).HasColumnName("mark");

                entity.Property(e => e.ReviewRext)
                    .HasColumnType("text")
                    .HasColumnName("review_rext");

                entity.Property(e => e.ToUserId).HasColumnName("to_user_id");

                entity.HasOne(d => d.FromUser)
                    .WithMany(p => p.ReviewFromUsers)
                    .HasForeignKey(d => d.FromUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reviews_Users");

                entity.HasOne(d => d.ToUser)
                    .WithMany(p => p.ReviewToUsers)
                    .HasForeignKey(d => d.ToUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reviews_Users1");
            });

            modelBuilder.Entity<SteeringWheelLocation>(entity =>
            {
                entity.ToTable("Steering_wheel_locations");

                entity.Property(e => e.SteeringWheelLocationId).HasColumnName("steering_wheel_location_id");

                entity.Property(e => e.SteeringWheelLocationName)
                    .HasMaxLength(10)
                    .HasColumnName("steering_wheel_location_name");
            });

            modelBuilder.Entity<Transmission>(entity =>
            {
                entity.Property(e => e.TransmissionId).HasColumnName("transmission_id");

                entity.Property(e => e.TransmissionName)
                    .HasMaxLength(50)
                    .HasColumnName("transmission_name");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .HasColumnName("first_name");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.LastLoginDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("last_login_datetime");

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .HasColumnName("last_name");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(15)
                    .HasColumnName("phone_number");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.RegistrarionDate)
                    .HasColumnType("date")
                    .HasColumnName("registrarion_date");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Users_Cities");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Regions");
            });

            modelBuilder.Entity<Year>(entity =>
            {
                entity.Property(e => e.YearId).HasColumnName("year_id");

                entity.Property(e => e.Year1).HasColumnName("year");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
