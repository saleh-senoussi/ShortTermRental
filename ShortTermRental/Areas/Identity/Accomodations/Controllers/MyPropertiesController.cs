/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShortTermRental.Areas.Identity.Accomodations.Models;
using ShortTermRental.Data;
using ShortTermRental.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShortTermRental.Areas.Identity.Accomodations.Controllers
{
    public class MyPropertiesController : Controller
    {
        // GET: /<controller>/
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public MyPropertiesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() =>
        _userManager.GetUserAsync(HttpContext.User);

        [HttpGet]
        public async Task<string> GetCurrentUserId()
        {
            ApplicationUser user = await GetCurrentUserAsync();
            return user?.Id;
        }

        public async Task<IActionResult> Index()
        {
            var Id = await GetCurrentUserId();
            //var UserProperties = _context.Properties.Where(x => x.HostId == Id);
            //var UserPricings = _context.Pricings.Where(x => x.HostId == Id);

            var MyProperties = _context.Pricings.Where(pricing => pricing.HostId == Id)
                .Join(_context.Properties.Where(property => property.HostId == Id),
                    pricing => pricing.PropertyId,
                    property => property.Id,
                    (pricing, property) =>
                        new MyPropertiesModel
                        {
                            Pricings = new PricingModel
                            {
                                PropertyId = pricing.PropertyId,
                                HostId = pricing.HostId,
                                RegularRate = pricing.RegularRate,
                                PercentDiscount = pricing.PercentDiscount,
                                DiscountedRate = pricing.DiscountedRate,
                                CleaningFee = pricing.CleaningFee
                            },
                            Properties = new PropertyModel
                            {
                                Id = property.Id,
                                Type = property.Type,
                                Title = property.Title,
                                MaximumGuests = property.MaximumGuests,
                                Available = property.Available,
                                Description = property.Description,
                                PrivateSpace = property.PrivateSpace,
                                Bathrooms = property.Bathrooms,
                                Bedrooms = property.Bedrooms,
                                Beds = property.Beds,
                                Address = property.Address,
                                City = property.City,
                                PostalCode = property.PostalCode,
                                Province = property.Province,
                                Country = property.Country,
                                Images = property.Images.ToArray<PropertyImage>(),
                                HostId = property.HostId,
                                Cleanliness = property.Cleanliness,
                                Accuracy = property.Accuracy,
                                CheckIn = property.CheckIn,
                                Communication = property.Communication,
                                Location = property.Location,
                                Value = property.Value,
                                Overall = property.Overall
                            }
                        }).AsEnumerable<MyPropertiesModel>();

            return View(MyProperties);
        }


    }
}
*/