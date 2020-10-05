using System;
using System.Collections;
using System.Collections.Generic;
using ShortTermRental.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp;

namespace ShortTermRental.Helpers
{
    public static class SeedData
    {
        public static async Task SeedUsers(IServiceProvider serviceProvider)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            ApplicationDbContext applicationDb = serviceProvider.GetRequiredService<ApplicationDbContext>();

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

            var _admin = await UserManager.FindByEmailAsync("admin@shortrental.com");
            if (_admin == null)
            {
                var admin = new ApplicationUser
                {
                    UserName = "admin@shortrental.com",
                    Email = "admin@shortrental.com"
                };

                var createAdmin = await UserManager.CreateAsync(admin, "Admin2019!");
                if (createAdmin.Succeeded)
                    await UserManager.AddToRoleAsync(admin, "Admin");
            }

            var _employee = await UserManager.FindByEmailAsync("employee@shortrental.com");
            if (_employee == null)
            {
                var employee = new ApplicationUser
                {
                    UserName = "employee@shortrental.com",
                    Email = "employee@shortrental.com"
                };

                var createEmployee = await UserManager.CreateAsync(employee, "Employee2019!");
                if (createEmployee.Succeeded)
                    await UserManager.AddToRoleAsync(employee, "Employee");
            }



            var _customer1 = await UserManager.FindByEmailAsync("customer1@shortrental.com");
            if (_customer1 == null)
            {
                var customer1 = new ApplicationUser
                {
                    UserName = "customer1@shortrental.com",
                    Email = "customer1@shortrental.com"
                };

                var createCustomer1 = await UserManager.CreateAsync(customer1, "1Customer2020!");
                if (createCustomer1.Succeeded)
                    await UserManager.AddToRoleAsync(customer1, "Customer");
            }

            var _customer2 = await UserManager.FindByEmailAsync("customer2@shortrental.com");
            if (_customer2 == null)
            {
                var customer2 = new ApplicationUser
                {
                    UserName = "customer2@shortrental.com",
                    Email = "customer2@shortrental.com"
                };

                var createCustomer2 = await UserManager.CreateAsync(customer2, "2Customer2020!");
                if (createCustomer2.Succeeded)
                    await UserManager.AddToRoleAsync(customer2, "Customer");
            }

            var _customer3 = await UserManager.FindByEmailAsync("customer3@shortrental.com");
            if (_customer3 == null)
            {
                var customer3 = new ApplicationUser
                {
                    UserName = "customer3@shortrental.com",
                    Email = "customer3@shortrental.com"
                };

                var createCustomer3 = await UserManager.CreateAsync(customer3, "3Customer2020!");
                if (createCustomer3.Succeeded)
                    await UserManager.AddToRoleAsync(customer3, "Customer");
            }

            var _customer4 = await UserManager.FindByEmailAsync("customer4@shortrental.com");
            if (_customer4 == null)
            {
                var customer4 = new ApplicationUser
                {
                    UserName = "customer4@shortrental.com",
                    Email = "customer4@shortrental.com"
                };

                var createCustomer4 = await UserManager.CreateAsync(customer4, "4Customer2020!");
                if (createCustomer4.Succeeded)
                    await UserManager.AddToRoleAsync(customer4, "Customer");
            }

            var _customer5 = await UserManager.FindByEmailAsync("customer5@shortrental.com");
            if (_customer5 == null)
            {
                var customer5 = new ApplicationUser
                {
                    UserName = "customer5@shortrental.com",
                    Email = "customer5@shortrental.com"
                };

                var createCustomer5 = await UserManager.CreateAsync(customer5, "5Customer2020!");
                if (createCustomer5.Succeeded)
                    await UserManager.AddToRoleAsync(customer5, "Customer");
            }

            //UserManager.SaveChanges();

            int i = 1;
            int count= await applicationDb.Properties.CountAsync<Property>();
            foreach (ApplicationUser host in UserManager.Users)
            {
                bool check = false;
                IList<string> roles = await UserManager.GetRolesAsync(host);
                foreach (string role in roles)
                {
                    if (role.Equals("Customer"))
                        check = true;
                }

                if (check)
                {
                    Property property = new Property
                    {
                        Type = "Entire Appartment",
                        Title = "Short Term Rental " + i + "!",
                        MaximumGuests = i,
                        Overall = 0,
                        Available = true,
                        Description = "Short Term Accomodation # " + i,
                        PrivateSpace = true,
                        Bathrooms = i % 3,
                        Bedrooms = i % 2,
                        Beds = i % 2,
                        Address = i + "2" + i + "Carleton St" + i,
                        City = "Ottawa",
                        PostalCode = "K" + i + "O" + " " + (i + 2) + "C" + (i + 1),
                        Province = "Ontario",
                        Country = "Canada",
                        HostId = host.Id
                    };

                    applicationDb.Properties.Add(property);
                    applicationDb.SaveChanges();
                    count++;

                    Pricing pricing = new Pricing
                    {
                        PropertyId = count,
                        HostId = property.HostId,
                        DiscountedRate = i * 10,
                        PercentDiscount = 0,
                        RegularRate = i*10,
                        CleaningFee = i + 10
                    };

                    applicationDb.Pricings.Add(pricing);
                    applicationDb.SaveChanges();
                    i++;
                }
            }

            /*

            int j = 1;
            // property;
            foreach (Property property in applicationDb.Properties)
            {
                applicationDb.Pricings.Add(
                    new Pricing
                    {
                        PropertyId = property.Id,
                        HostId = property.HostId,
                        NightlyRate = j * 10,
                        PercentDiscount = 0,
                        CleaningFee = j + 10
                    });
                applicationDb.SaveChanges();
                j++;
            }*/
            applicationDb.SaveChanges();
        }

        
        /*public static async Task SeedProperties(IServiceProvider serviceProvider)
        {
            //ModelBuilder modelBuilder = serviceProvider.GetRequiredService<ModelBuilder>();
            ApplicationDbContext applicationDb = serviceProvider.GetRequiredService<ApplicationDbContext>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            int i = 1;
            foreach (ApplicationUser host in UserManager.Users)
            {
                if (UserManager.GetRolesAsync(host).Equals("Customer"))
                {
                    applicationDb.Properties.Add(
                        new Property
                        {
                            Type = "Entire Appartment",
                            Title = "Short Term Rental " + i + "!",
                            MaximumGuests = i,
                            ReviewAverage = 0,
                            Available = true,
                            Description = "Short Term Accomodation # " + i,
                            PrivateSpace = true,
                            Bathrooms = i % 3,
                            Bedrooms = i % 2,
                            Beds = i % 2,
                            Address = i + "2" + i + "Carleton St" + i,
                            City = "Ottawa",
                            PostalCode = "K" + i + "O" + " " + (i + 2) + "C" + (i + 1),
                            Province = "Ontario",
                            Country = "Canada",
                            HostId = host.Id
                        });
                    i++;

                    applicationDb.SaveChanges();
                }
            }

            applicationDb.SaveChanges();

            int j = 1;
            // property;
            foreach (Property property in applicationDb.Properties)
            {
                applicationDb.Pricings.Add(
                    new Pricing
                    {
                        PropertyId = property.Id,
                        HostId = property.HostId,
                        NightlyRate = i * 10,
                        PercentDiscount = 0,
                        CleaningFee = i + 10
                    });
                applicationDb.SaveChanges();
                j++;
            }
            applicationDb.SaveChanges();
        }*/
    }
}
