using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShortTermRental.Data;
using ShortTermRental.Models;

namespace ShortTermRental.Areas.Identity.Pages.Account.Accomodations
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public DetailsModel(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public MyPropertiesModel Property { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Property property = await _context.Properties.FirstOrDefaultAsync(m => m.Id == id);
            
            if (property == null)
            {
                return NotFound();
            }

            var user = await _userManager.GetUserAsync(User);
            Pricing pricing = await _context.Pricings.FirstOrDefaultAsync(m => m.PropertyId == id && m.HostId == user.Id);

            if(pricing == null)
            {
                return RedirectToAction("./CreatePricing", new { @propertyId = (int)id });
            }

            Property = new MyPropertiesModel
            {
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
                    //Images = property.Images.ToArray<PropertyImage>(),
                    Cleanliness = property.Cleanliness,
                    Accuracy = property.Accuracy,
                    CheckIn = property.CheckIn,
                    Communication = property.Communication,
                    Location = property.Location,
                    Value = property.Value,
                    Overall = property.Overall
                },
                Pricings = new PricingModel
                {
                    RegularRate = pricing.RegularRate,
                    PercentDiscount = pricing.PercentDiscount,
                    DiscountedRate = pricing.DiscountedRate,
                    CleaningFee = pricing.CleaningFee
                }
            };
            return Page();
        }
    }
}
