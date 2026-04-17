using COMP003B.Assignment4_1.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4_1.Controllers
{
    [Route("concert")]
    public class ConcertController : Controller
    {
        [HttpGet("register/{city?}")]
        public IActionResult Register(string? city)
        {
            var model = new ConcertRegistration
            {
                City = city ?? "",
                TicketCount = 1
            };

            ViewData["Title"] = "Register";
            return View(model);
        }

        [HttpPost("register")]
        [ValidateAntiForgeryToken]
        public IActionResult Register(ConcertRegistration model)
        {
            ViewData["Title"] = "Register";

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Confirmation", new
            {
                id = 1,
                fullName = model.FullName,
                city = model.City,
                ticketCount = model.TicketCount
            });
        }

        [HttpGet("confirmation/{id:int}")]
        public IActionResult Confirmation(int id, string fullName, string city, int ticketCount)
        {
            var model = new ConcertRegistration
            {
                Id = id,
                FullName = fullName,
                City = city,
                TicketCount = ticketCount
            };

            ViewData["Title"] = "Confirmation";
            return View(model);
        }
    }
}
