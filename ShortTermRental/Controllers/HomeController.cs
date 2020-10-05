using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShortTermRental.Models;
using Microsoft.AspNetCore.Authorization;
using ShortTermRental.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Routing;

namespace ShortTermRental.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index([Bind("City,Province,CheckIn,CheckOut,Guests")] BookAccomodation BookAccomodation)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("SearchReservation", new
                {
                    @City = BookAccomodation.City,
                    @Province = BookAccomodation.Province,
                    @CheckIn = BookAccomodation.CheckIn,
                    @CheckOut = BookAccomodation.CheckOut,
                    @Guests = BookAccomodation.Guests
                });
            }
            else
                return View();
        }
        
        public IActionResult SearchReservation(String City, String Province, DateTime CheckIn, DateTime CheckOut, int Guests)
        {
            var properties = _context.Properties;
            var pricings = _context.Pricings;

            IEnumerable<PropertyViewModel> _booking = properties.Where(property => property.City.ToLower().Contains(City.ToLower()))
                                    .Where(property => property.Province.ToLower().Contains(Province.ToLower()))
                                    .Join(pricings,
                                            property => property.Id,
                                            pricing => pricing.PropertyId,
                                            (property, pricing) =>
                                            new PropertyViewModel
                                            {
                                                PropertyId = property.Id,
                                                Type = property.Type,
                                                Title = property.Title,
                                                MaximumGuests = property.MaximumGuests,
                                                ReviewAverage = property.Overall,
                                                Available = property.Available,
                                                Description = property.Description,
                                                Bathrooms = property.Bathrooms,
                                                Bedrooms = property.Bedrooms,
                                                Beds = property.Beds,
                                                DiscountedRate = pricing.DiscountedRate,
                                                City = property.City,
                                                Province = property.Province
                                            })
                                    .OrderBy(property => property.DiscountedRate)
                                    .AsEnumerable<PropertyViewModel>();

            if (_booking.Count<PropertyViewModel>() == 0)
            {
                return RedirectToAction(nameof(NoBookingFound));
            }
            
            return View(_booking);
        }

        [HttpGet]
        public IActionResult NoBookingFound()
        {
            return View();
        }

        
        public async Task<IActionResult> PropertyDetails(int? Id)
        {
            if(Id==null)
            {
                return NotFound();
            }

            IList<PropertyViewModel> property = await _context.Properties.Where(property => property.Id == Id)
                                    .Join(_context.Pricings,
                                            property => property.Id,
                                            pricing => pricing.PropertyId,
                                            (property, pricing) =>
                                            new PropertyViewModel
                                            {
                                                PropertyId = property.Id,
                                                Type = property.Type,
                                                Title = property.Title,
                                                MaximumGuests = property.MaximumGuests,
                                                ReviewAverage = property.Overall,
                                                Available = property.Available,
                                                Description = property.Description,
                                                Bathrooms = property.Bathrooms,
                                                Bedrooms = property.Bedrooms,
                                                Beds = property.Beds,
                                                DiscountedRate = pricing.DiscountedRate,
                                                City = property.City,
                                                Province = property.Province
                                            })
                                    .ToListAsync<PropertyViewModel>();
            
            return View(property.Single<PropertyViewModel>());
        }

        [Authorize(Roles="Customer")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
