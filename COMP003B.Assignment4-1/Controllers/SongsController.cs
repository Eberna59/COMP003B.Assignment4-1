using COMP003B.Assignment4_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Reflection;

namespace COMP003B.Assignment4_1.Controllers
{
    public class SongsController : Controller
    {
        public IActionResult Index()
        {
            var songs = new List<Song>
            {
                new Song { Id = 1, Title = "Monochromatic", Album = "Single", Description = "My favorite song", Year = "2025"},
                new Song { Id = 2, Title = "...And to Those I Love, Thanks for Sticking around", Album = "Single", Description = "Number one Selling song of the Year", Year = "2020"}
            };

            ViewData["Title"] = "Songs";
            return View(songs);
        }

        public IActionResult Albums()
        {
            var songs = new List<Song>
            {
                new Song { Id = 3, Title = "THY WILL BE DONE", Album = "Recent Album", Description = "Best Seller of 2025", Year = "2025" },
                new Song { Id = 4, Title = "New World Depression", Album = "Best Selling Album", Description = "Best Seller of 2024", Year = "2024" },
            };

            ViewData["Title"] = "Albums";
            return View(songs);
        }

        public IActionResult Details(int id)
        {
            var song = new Song
            {
                Id = id,
                Title = "Sample Song",
                Album = "Sample Album",
                Description = "Sample description",
                Year = "Sample Year"
            };

            ViewData["Title"] = "Details";
            return View(song);
        }
    }
}
