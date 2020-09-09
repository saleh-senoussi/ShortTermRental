using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using ShortTermRental.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShortTermRental.Helpers;
using System.Security.Cryptography;

namespace ShortTermRental
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = false;
            })
                .AddDefaultUI()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            //
            
            //CreateRoles(serviceProvider).Wait();
            //CreateProperties(serviceProvider);
            //SeedData.SeedUsers(serviceProvider).Wait();
            //SeedData.SeedProperties(serviceProvider).Wait();
        }
        
        private async Task CreateRoles(IServiceProvider serviceProvider)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            //var modelBuilder = serviceProvider.GetRequiredService<ModelBuilder>();

            string[] roleNames = { "Admin", "Employee", "Customer" };
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            
            var _customer = await UserManager.FindByEmailAsync("customer@customer.com");
            ApplicationUser customer = null;
            //string hostId = "";
            if (_customer == null)
            {
                customer = new ApplicationUser
                {
                    UserName = "customer@customer.com",
                    Email = "customer@customer.com"
                };

                var createCustomer = await UserManager.CreateAsync(customer, "Customer2019!");
                if (createCustomer.Succeeded)
                    await UserManager.AddToRoleAsync(customer, "Customer");
                //hostId = customer.Id;
            }
            /*else
            {
                hostId = _customer.Id;
            }

            if (hostId != null)
            {
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
                        HostId = hostId
                    });

                modelBuilder.Entity<Pricing>().HasData(
                    new Pricing
                    {
                        PropertyId = 1,
                        HostId = hostId,
                        NightlyRate = 25,
                        PercentDiscount = 0,
                        CleaningFee = 15
                    });
            }*/
        }
        /*
        private async Task CreateProperties(IServiceProvider serviceProvider)
        {
            var modelBuilder = serviceProvider.GetRequiredService<ModelBuilder>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            //var user = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>().Users;

            var _customer = await UserManager.FindByEmailAsync("customer@customer.com");

            if (_customer != null)
            {
                string hostId = _customer.Id;

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
                        HostId = hostId
                    });

                modelBuilder.Entity<Pricing>().HasData(
                    new Pricing
                    {
                        PropertyId = 1,
                        HostId = hostId,
                        NightlyRate = 25,
                        PercentDiscount = 0,
                        CleaningFee = 15
                    });
            }
        }*/
    }
}
