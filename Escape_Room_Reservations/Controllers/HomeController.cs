using Escape_Room_Reservations.Data;
using Escape_Room_Reservations.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Escape_Room_Reservations.Data;

namespace Escape_Room_Reservations.Controllers
{
	public class HomeController : Controller
	{
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var userCount = _context.Users.Count();
            var roomCount = _context.Rooms.Count();

            ViewBag.UserCount = userCount;
            ViewBag.RoomCount = roomCount;

            return View();
        }

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