using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alex_Andersen.Models
{
    public class EFContext : DbContext
    {
        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=EFCore;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);

        }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Drivers> Drivers { get; set; }
        public DbSet<Locations> Locations { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<TripLocations> TripLocations { get; set; }
        //public DbSet<TripRequests> TripRequests { get; set; }
        public DbSet<Trips> Trips { get; set; }
        public DbSet<TypePreferences> TypePreferences { get; set; }
        public DbSet<UserMessages> UserMessages { get; set; }

        public DbSet<Users> Users { get; set; }
    }
}
