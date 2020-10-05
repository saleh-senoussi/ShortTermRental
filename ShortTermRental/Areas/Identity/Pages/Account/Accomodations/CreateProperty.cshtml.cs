using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShortTermRental.Data;
using ShortTermRental.Models;

namespace ShortTermRental.Areas.Identity.Pages.Account.Accomodations
{
    public class CreatePropertyModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CreatePropertyModel(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PropertyModel Property { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.GetUserAsync(User);

            Property property = new Property
            {
                Type = Property.Type,
                Title = Property.Title,
                MaximumGuests = Property.MaximumGuests,
                Available = Property.Available,
                Description = Property.Description,
                PrivateSpace = Property.PrivateSpace,
                Bathrooms = Property.Bathrooms,
                Bedrooms = Property.Bedrooms,
                Beds = Property.Beds,
                Address = Property.Address,
                City = Property.City,
                PostalCode = Property.PostalCode,
                Province = Property.Province,
                Country = Property.Country,
                Images = null,
                HostId = user.Id,
                Cleanliness = Property.Cleanliness,
                Accuracy = Property.Accuracy,
                CheckIn = Property.CheckIn,
                Communication = Property.Communication,
                Location = Property.Location,
                Value = Property.Value,
                Overall = Property.Overall
            };

            _context.Properties.Add(property);
            await _context.SaveChangesAsync();

            return RedirectToPage("./CreatePricing", new { @propertyId = property.Id });
        }
    }
}
