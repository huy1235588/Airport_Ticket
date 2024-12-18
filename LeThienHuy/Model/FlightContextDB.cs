using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LeThienHuy.Model
{
    public partial class FlightContextDB : DbContext
    {
        public FlightContextDB()
            : base("name=FlightContextDB")
        {
        }

        public virtual DbSet<Aircraft> Aircrafts { get; set; }
        public virtual DbSet<Airport> Airports { get; set; }
        public virtual DbSet<Amenity> Amenities { get; set; }
        public virtual DbSet<AmenitiesTicket> AmenitiesTickets { get; set; }
        public virtual DbSet<CabinType> CabinTypes { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aircraft>()
                .HasMany(e => e.Schedules)
                .WithRequired(e => e.Aircraft)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Airport>()
                .Property(e => e.IATACode)
                .IsUnicode(false);

            modelBuilder.Entity<Airport>()
                .HasMany(e => e.Routes)
                .WithRequired(e => e.Airport)
                .HasForeignKey(e => e.DepartureAirportID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Airport>()
                .HasMany(e => e.Routes1)
                .WithRequired(e => e.Airport1)
                .HasForeignKey(e => e.ArrivalAirportID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Amenity>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Amenity>()
                .HasMany(e => e.AmenitiesTickets)
                .WithRequired(e => e.Amenity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Amenity>()
                .HasMany(e => e.CabinTypes)
                .WithMany(e => e.Amenities)
                .Map(m => m.ToTable("AmenitiesCabinType").MapLeftKey("AmenityID").MapRightKey("CabinTypeID"));

            modelBuilder.Entity<AmenitiesTicket>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CabinType>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.CabinType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Airports)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Offices)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Route>()
                .HasMany(e => e.Schedules)
                .WithRequired(e => e.Route)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Schedule>()
                .Property(e => e.Time)
                .HasPrecision(5);

            modelBuilder.Entity<Schedule>()
                .Property(e => e.EconomyPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Schedule>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.Schedule)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ticket>()
                .HasMany(e => e.AmenitiesTickets)
                .WithRequired(e => e.Ticket)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
