using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Alex_Andersen.Models
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Availability> Availabilities { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<DriversHasLicense> DriversHasLicenses { get; set; }
        public virtual DbSet<License> Licenses { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<TripHasDriver> TripHasDrivers { get; set; }
        public virtual DbSet<TripRequest> TripRequests { get; set; }
        public virtual DbSet<TripsLocation> TripsLocations { get; set; }
        public virtual DbSet<TypePreference> TypePreferences { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserMessage> UserMessages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Filename=alexandersen.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Availability>(entity =>
            {
                entity.ToTable("Availability");

                entity.Property(e => e.AvailabilityId)
                    .HasColumnType("INT IDENTITY(1,1)")
                    .ValueGeneratedNever()
                    .HasColumnName("AvailabilityID");

                entity.Property(e => e.AvailabilityStatus).HasColumnType("BIT");

                entity.Property(e => e.DriverId)
                    .HasColumnType("INT")
                    .HasColumnName("DriverID");

                entity.Property(e => e.EndDate).HasColumnType("DATETIME");

                entity.Property(e => e.StartDate).HasColumnType("DATETIME");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.Availabilities)
                    .HasForeignKey(d => d.DriverId);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityId)
                    .HasColumnType("INT IDENTITY(1,1)")
                    .ValueGeneratedNever()
                    .HasColumnName("CityID");

                entity.Property(e => e.CityName).HasColumnType("VARCHAR(200)");

                entity.Property(e => e.CountryId)
                    .HasColumnType("INT")
                    .HasColumnName("CountryID");

                entity.Property(e => e.Zip)
                    .HasColumnType("INT")
                    .HasColumnName("ZIP");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.CountryId);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId)
                    .HasColumnType("INT IDENTITY(1,1)")
                    .ValueGeneratedNever()
                    .HasColumnName("CountryID");

                entity.Property(e => e.CountryCode).HasColumnType("VARCHAR(2)");

                entity.Property(e => e.CountryName).HasColumnType("VARCHAR(200)");

                entity.Property(e => e.PhoneCode).HasColumnType("VARCHAR(4)");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId)
                    .HasColumnType("INT IDENTITY(1,1)")
                    .ValueGeneratedNever()
                    .HasColumnName("DepartmentID");

                entity.Property(e => e.CityId)
                    .HasColumnType("INT")
                    .HasColumnName("CityID");

                entity.Property(e => e.DepartmentAddress).HasColumnType("VARCHAR(200)");

                entity.Property(e => e.DepartmentName).HasColumnType("VARCHAR(200)");

                entity.Property(e => e.UserId)
                    .HasColumnType("INT")
                    .HasColumnName("UserID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.CityId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.Property(e => e.DriverId)
                    .HasColumnType("INT IDENTITY(1,1)")
                    .ValueGeneratedNever()
                    .HasColumnName("DriverID");

                entity.Property(e => e.CityId)
                    .HasColumnType("INT")
                    .HasColumnName("CityID");

                entity.Property(e => e.CountryId)
                    .HasColumnType("INT")
                    .HasColumnName("CountryID");

                entity.Property(e => e.DriverResidence).HasColumnType("VARCHAR(45)");

                entity.Property(e => e.ImageFile)
                    .HasColumnType("VARCHAR(200)")
                    .HasColumnName("Image_file");

                entity.Property(e => e.IsDriverActive).HasColumnType("BIT");

                entity.Property(e => e.TypePreferenceId)
                    .HasColumnType("INT")
                    .HasColumnName("TypePreferenceID");

                entity.Property(e => e.UserId)
                    .HasColumnType("INT")
                    .HasColumnName("UserID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Drivers)
                    .HasForeignKey(d => d.CityId);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Drivers)
                    .HasForeignKey(d => d.CountryId);

                entity.HasOne(d => d.TypePreference)
                    .WithMany(p => p.Drivers)
                    .HasForeignKey(d => d.TypePreferenceId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Drivers)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<DriversHasLicense>(entity =>
            {
                entity.HasKey(e => new { e.LicenseId, e.DriverId });

                entity.ToTable("Drivers_has_licenses");

                entity.Property(e => e.LicenseId)
                    .HasColumnType("INT")
                    .HasColumnName("LicenseID");

                entity.Property(e => e.DriverId)
                    .HasColumnType("INT")
                    .HasColumnName("DriverID");

                entity.Property(e => e.ExpirationDate).HasColumnType("DATETIME");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.DriversHasLicenses)
                    .HasForeignKey(d => d.DriverId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.License)
                    .WithMany(p => p.DriversHasLicenses)
                    .HasForeignKey(d => d.LicenseId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<License>(entity =>
            {
                entity.Property(e => e.LicenseId)
                    .HasColumnType("INT IDENTITY(1,1)")
                    .ValueGeneratedNever()
                    .HasColumnName("LicenseID");

                entity.Property(e => e.LicenseName).HasColumnType("VARCHAR(100)");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.LocationId)
                    .HasColumnType("INT IDENTITY(1,1)")
                    .ValueGeneratedNever()
                    .HasColumnName("LocationID");

                entity.Property(e => e.CityId)
                    .HasColumnType("INT")
                    .HasColumnName("CityID");

                entity.Property(e => e.LocationAddress).HasColumnType("VARCHAR(255)");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.CityId);
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.MessageId)
                    .HasColumnType("INT IDENTITY(1,1)")
                    .ValueGeneratedNever()
                    .HasColumnName("MessageID");

                entity.Property(e => e.IsMessageRead).HasColumnType("BIT");

                entity.Property(e => e.MessageTitle).HasColumnType("VARCHAR(45)");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .HasColumnType("INT IDENTITY(1,1)")
                    .ValueGeneratedNever()
                    .HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasColumnType("VARCHAR(15)");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.StatusId)
                    .HasColumnType("INT IDENTITY(1,1)")
                    .ValueGeneratedNever()
                    .HasColumnName("StatusID");

                entity.Property(e => e.StatusName).HasColumnType("VARCHAR(100)");
            });

            modelBuilder.Entity<Trip>(entity =>
            {
                entity.Property(e => e.TripId)
                    .HasColumnType("INT IDENTITY(1,1)")
                    .ValueGeneratedNever()
                    .HasColumnName("TripID");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("INT")
                    .HasColumnName("DepartmentID");

                entity.Property(e => e.EndDate).HasColumnType("DATETIME");

                entity.Property(e => e.IsTripExpress).HasColumnType("BIT");

                entity.Property(e => e.StartDate).HasColumnType("DATETIME");

                entity.Property(e => e.StatusId)
                    .HasColumnType("INT")
                    .HasColumnName("StatusID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.DepartmentId);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Trips)
                    .HasForeignKey(d => d.StatusId);
            });

            modelBuilder.Entity<TripHasDriver>(entity =>
            {
                entity.HasKey(e => new { e.DriverId, e.TripId });

                entity.ToTable("Trip_has_drivers");

                entity.Property(e => e.DriverId)
                    .HasColumnType("INT")
                    .HasColumnName("DriverID");

                entity.Property(e => e.TripId)
                    .HasColumnType("INT")
                    .HasColumnName("TripID");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.TripHasDrivers)
                    .HasForeignKey(d => d.DriverId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Trip)
                    .WithMany(p => p.TripHasDrivers)
                    .HasForeignKey(d => d.TripId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TripRequest>(entity =>
            {
                entity.HasKey(e => new { e.DriverId, e.TripId });

                entity.Property(e => e.DriverId)
                    .HasColumnType("INT")
                    .HasColumnName("DriverID");

                entity.Property(e => e.TripId)
                    .HasColumnType("INT")
                    .HasColumnName("TripID");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.TripRequests)
                    .HasForeignKey(d => d.DriverId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Trip)
                    .WithMany(p => p.TripRequests)
                    .HasForeignKey(d => d.TripId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TripsLocation>(entity =>
            {
                entity.HasKey(e => e.TripsLocationsId);

                entity.ToTable("Trips_locations");

                entity.Property(e => e.TripsLocationsId)
                    .HasColumnType("INT IDENTITY(1,1)")
                    .ValueGeneratedNever()
                    .HasColumnName("TripsLocationsID");

                entity.Property(e => e.LocationEndpoint).HasColumnType("BIT");

                entity.Property(e => e.LocationId)
                    .HasColumnType("INT")
                    .HasColumnName("LocationID");

                entity.Property(e => e.TripId)
                    .HasColumnType("INT")
                    .HasColumnName("TripID");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.TripsLocations)
                    .HasForeignKey(d => d.LocationId);

                entity.HasOne(d => d.Trip)
                    .WithMany(p => p.TripsLocations)
                    .HasForeignKey(d => d.TripId);
            });

            modelBuilder.Entity<TypePreference>(entity =>
            {
                entity.Property(e => e.TypePreferenceId)
                    .HasColumnType("INT IDENTITY(1,1)")
                    .ValueGeneratedNever()
                    .HasColumnName("TypePreferenceID");

                entity.Property(e => e.TypeName).HasColumnType("VARCHAR(45)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .HasColumnType("INT IDENTITY(1,1)")
                    .ValueGeneratedNever()
                    .HasColumnName("UserID");

                entity.Property(e => e.FirstName).HasColumnType("VARCHAR(255)");

                entity.Property(e => e.LastName).HasColumnType("VARCHAR(255)");

                entity.Property(e => e.RoleId)
                    .HasColumnType("INT")
                    .HasColumnName("RoleID");

                entity.Property(e => e.UserEmail).HasColumnType("VARCHAR(45)");

                entity.Property(e => e.UserName).HasColumnType("VARCHAR(15)");

                entity.Property(e => e.UserPassword).HasColumnType("VARCHAR(255)");

                entity.Property(e => e.UserPhoneNumber).HasColumnType("INT");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<UserMessage>(entity =>
            {
                entity.HasKey(e => e.UserMessagesId);

                entity.ToTable("User_messages");

                entity.Property(e => e.UserMessagesId)
                    .HasColumnType("INT IDENTITY(1,1)")
                    .ValueGeneratedNever()
                    .HasColumnName("UserMessagesID");

                entity.Property(e => e.MesssageId)
                    .HasColumnType("INT")
                    .HasColumnName("MesssageID");

                entity.Property(e => e.SenderReciever).HasColumnType("BIT");

                entity.Property(e => e.UserId)
                    .HasColumnType("INT")
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Messsage)
                    .WithMany(p => p.UserMessages)
                    .HasForeignKey(d => d.MesssageId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserMessages)
                    .HasForeignKey(d => d.UserId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
