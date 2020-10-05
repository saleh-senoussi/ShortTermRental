using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShortTermRental.Data;
using ShortTermRental.Models;

namespace ShortTermRental.Areas.Identity.Pages.Account.Accomodations
{
    public class CreatePricingModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CreatePricingModel(ApplicationDbContext context,
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
        public PricingModel Pricing { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? propertyId)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if(propertyId==null)
            {
                return NotFound();
            }

            var user = await _userManager.GetUserAsync(User);

            _context.Pricings.Add(
                new Pricing
                {
                    PropertyId = (int)propertyId,
                    HostId = user.Id,
                    RegularRate = Pricing.RegularRate,
                    PercentDiscount = Pricing.PercentDiscount,
                    DiscountedRate = Pricing.RegularRate*(1- Pricing.PercentDiscount/100),
                    CleaningFee = Pricing.CleaningFee
                });

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
