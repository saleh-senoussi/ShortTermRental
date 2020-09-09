using System;
namespace ShortTermRental.Helpers
{
    public class Trash
    {
        public Trash()
        {
        }

        // Home

        /*@section Scripts {
    <script>jQuery(document).ready(function () {
            $('.btn').click(function (e) {
                var btn = $(this);
                var City = btn.attr('City');
                var Province = btn.attr('Province');
                var CheckIn = btn.attr('CheckIn');
                var CheckOut = btn.attr('CheckOut');
                var Guests = btn.attr('Guests');
                function()

                $.('/Home/SearchReservation?City=' + City + '&Province=' + Province + '&CheckIn' + CheckIn + '&CheckOut' + CheckOut + '&Guests' + Guests);
            });
        });</script>
}*/

        //ApplicationDbContext

        /*
            
        int i = 1;
        foreach (ApplicationUser host in this.Users)
        {
            bool check = false;
            foreach (IdentityRole role in host.UserRoles)
            {
                if (role.ToString().Equals("Customer"))
                {
                    check = true;
                }
            }
            if (check)
            {
                modelBuilder.Entity<Property>().HasData(
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
            }
        }

        int j = 1;
        // property;
        foreach (Property property in this.Properties)
        {
            modelBuilder.Entity<Pricing>().HasData(
                new Pricing
                {
                    PropertyId = property.Id,
                    HostId = property.HostId,
                    NightlyRate = i * 10,
                    PercentDiscount = 0,
                    CleaningFee = i + 10
                });
            j++;
        }
        //this.Users
        //ModelBuilder modelBuilder = serviceProvider.GetRequiredService<ModelBuilder>();
        //ApplicationDbContext applicationDb = serviceProvider.GetRequiredService<ApplicationDbContext>();
        //var UserManager = modelBuilder.;
        //serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
        */





        public static class SeedData
        {
            //private readonly IServiceProvider _serviceProvider;

            /*public SeedData(IServiceProvider serviceProvider)
            {
                _serviceProvider = serviceProvider;
                //SeedUsers(serviceProvider).Wait();
                //SeedProperties(serviceProvider);
            }*/
            /*
            private static void SeedUsers(IServiceProvider serviceProvider)
            {
                var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

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
            }


            private void SeedProperties(IServiceProvider serviceProvider)
            {
                ModelBuilder modelBuilder = serviceProvider.GetRequiredService<ModelBuilder>();
                ApplicationDbContext applicationDb = serviceProvider.GetRequiredService<ApplicationDbContext>();
                var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                int i = 1;
                foreach (ApplicationUser host in UserManager.Users)
                {
                    if (UserManager.GetRolesAsync(host).Equals("Customer"))
                    {
                        modelBuilder.Entity<Property>().HasData(
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
                    }
                }

                int j = 1;
                // property;
                foreach (Property property in applicationDb.Properties)
                {
                    modelBuilder.Entity<Pricing>().HasData(
                        new Pricing
                        {
                            PropertyId = property.Id,
                            HostId = property.HostId,
                            NightlyRate = i * 10,
                            PercentDiscount = 0,
                            CleaningFee = i + 10
                        });
                    j++;
                }
            }*/


        }
        /*
             <script>
        $(function () {
            jQuery.validator.addMethod('dategreaterthancheckin',
                function (value, element, params) {
                    // Get element value. Classic genre has value '0'.
                    var genre = $(params[0]).val(),
                        year = params[1],
                        date = new Date(value);
                    if (genre && genre.length > 0 && genre[0] === '0') {
                        // Since this is a classic movie, invalid if release date is after given year.
                        return date.getFullYear() <= year;
                    }

                    return true;
                });

            jQuery.validator.unobtrusive.adapters.add('classicmovie',
                ['element', 'year'],
                function (options) {
                    var element = $(options.form).find('select#Genre')[0];
                    options.rules['classicmovie'] = [element, parseInt(options.params['year'])];
                    options.messages['classicmovie'] = options.message;
                });
        }(jQuery));
    </script>
         */

        /*public BookAccomodation(string City, string Province, DateTime CheckIn, DateTime CheckOut, int Guests)
        {
            this.City = City;
            this.Province = Province;
            this.CheckIn = CheckIn;
            this.CheckOut = CheckOut;
            this.Guests = Guests;
        }*/
        /*
        public bool IsValid()
        {
            //bool chec
            return this.City != "" && this.Province != "" && this.Guests != 0;
        }*/
    }
}

/*class DateGreaterThanCheckInAttribute : ValidationAttribute, IClientModelValidator
    {
        private string DateToCompareToFieldName { get; set; }
        private DateTime checkIn { get; set; }

        public DateGreaterThanCheckIn(string dateToCompareToFieldName)
        {
            DateToCompareToFieldName = dateToCompareToFieldName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime checkOut = (DateTime)value;
            checkIn = (DateTime)validationContext.ObjectType.GetProperty(DateToCompareToFieldName).GetValue(validationContext.ObjectInstance, null);

            if (checkOut > checkIn)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Check out date must be greater than check in!");
            }
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-dategreaterthancheckin", "Check out date must be greater than check in!");

            var checkin = checkIn.ToString(CultureInfo.InvariantCulture);
            context.Attributes.Add("data-val-dategreaterthancheckin-checkin", checkin);
        }

        /*
        public IEnumerable<ClientModelValidationContext> GetClientValidationRules(ModelMetadata metadata, ActionContext context)
        {
            var rule = new ClientModelValidationContext()
            {
                ValidationType = "ValidateDateGreaterThanCheckIn",
                ErrorMessage = FormatErrorMessage(metadata.GetDisplayName()),
            };

            rule.ValidationParameters.Add("checkin", MinimumDateProperty.ToShortDateString());
            rule.ValidationParameters.Add("maximumdate", MaximumDateProperty.ToShortDateString());

            yield return rule;
        }*/


/*public Property(int Id, string Type, string Title, int MaximumGuests, double ReviewAverage,
            string RoomType, string Description, bool PrivateBathroom, bool PrivateSpace, int Bathrooms,
            int Bedrooms, int Beds, string Address, string City, string PostalCode, string Province,
            string Country, Guid HostId)
        {
            this.Id = Id;
            this.Type = Type;
            this.Title = Title;
            this.MaximumGuests = MaximumGuests;
            this.ReviewAverage = ReviewAverage;
            this.Available = true;
            this.RoomType = RoomType;
            this.Description = Description;
            this.PrivateBathroom = PrivateBathroom;
            this.PrivateSpace = PrivateSpace;
            this.Bathrooms = Bathrooms;
            this.Bedrooms = Bedrooms;
            this.Beds = Beds;
            this.Address = Address;
            this.City = City;
            this.PostalCode = PostalCode;
            this.Province = Province;
            this.Country = Country;
            this.HostId = HostId;
        }
        */


//[DataType(DataType.Currency)]
//[Authorize(Roles ="Employee,Admin")]
//public double? Salary { get; set; }
//[Authorize(Roles = "Employee,Admin")]
//public string? Position { get; set; }
//[Authorize(Roles = "Admin")]
//public ICollection<IdentityRole> UserRoles { get; set; }
//[Authorize(Roles = "Employee,Admin,Customer")]
//public IEnumerable<Property> properties { get; set; }
//[Authorize(Roles = "Employee,Admin,Customer")]
//public IEnumerable<Booking> bookings { get; set; }
