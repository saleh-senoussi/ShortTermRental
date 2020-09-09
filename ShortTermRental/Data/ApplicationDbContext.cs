using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace ShortTermRental.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BranchEmployee>()
            .HasKey(t => new { t.BranchId, t.EmployeeUserId });

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BranchGuest>()
            .HasKey(t => new { t.BranchId, t.GuestUserId });

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BranchHost>()
            .HasKey(t => new { t.BranchId, t.HostUserId });*/
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Payment>()
            //.HasCheckConstraint("UserConstraint", "GuestId not null")
            .HasKey(t => new { t.PropertyId, t.GuestId, t.HostId, t.BookingId });

            modelBuilder.Entity<Pricing>()
            .HasKey(t => new { t.PropertyId, t.HostId });

            modelBuilder.Entity<Review>()
            .HasKey(t => new { t.PropertyId, t.GuestId, t.BookingId });
            /*
            modelBuilder.Entity<Property>().HasData(
                new Property
                {
                    Type = "Entire Appartment",
                    Title = "Short Term Rental 1!",
                    MaximumGuests = 1,
                    ReviewAverage = 0,
                    Available = true,
                    Description = "Short Term Accomodation # 1",
                    PrivateSpace = true,
                    Bathrooms = 2,
                    Bedrooms = 2,
                    Beds = 2,
                    Address = "12 Carleton St",
                    City = "Ottawa",
                    PostalCode = "K1O 2C3",
                    Province = "Ontario",
                    Country = "Canada",
                    HostId = "63c391e5-0da5-45ba-a103-228822ea8fff"
                }) ;*/
        }

        //protected override void 
    //}
    }
}
