using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShortTermRental.Data;

namespace ShortTermRental.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            public string Address { get; set; }
            [Required]
            [StringLength(25)]
            public string City { get; set; }
            [Required]
            [DataType(DataType.PostalCode)]
            [Display(Name = "Postal Code")]
            public string PostalCode { get; set; }
            [Required]
            public string Province { get; set; }
            [Required]
            public string Country { get; set; }
            [Required]
            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            Username = userName;

            Input = new InputModel
            {
                Address = user.Address,
                City = user.City,
                PostalCode = user.PostalCode,
                Province = user.Province,
                Country = user.Country,
                PhoneNumber = user.PhoneNumber
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }


            if (Input.Address != user.Address)
            {
                user.Address = Input.Address;
            }

            if (Input.City != user.City)
            {
                user.City = Input.City;
            }

            if (Input.PostalCode != user.PostalCode)
            {
                user.PostalCode = Input.PostalCode;
            }

            if (Input.Province != user.Province)
            {
                user.Province = Input.Province;
            }

            if (Input.Country != user.Country)
            {
                user.Country = Input.Country;
            }

            await _userManager.UpdateAsync(user);

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }

    public class CustomBirthDateRangeAttribute : RangeAttribute//, IClientModelValidator
    {

        public CustomBirthDateRangeAttribute() : base(typeof(DateTime), (DateTime.Now.AddYears(-150)).ToString("yyyy-MM-dd"), (DateTime.Now.AddYears(-18)).ToString("yyyy-MM-dd"))
        { }

        public override string FormatErrorMessage(string name)
        {
            return "You should be at least be 18 years old to create an account.";
        }
    }
}
