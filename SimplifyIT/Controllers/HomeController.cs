using Microsoft.AspNetCore.Mvc;
using SimplifyIT.Models;
using System.Diagnostics;

namespace SimplifyIT.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Contacts()
		{
			return View();
		}

		public IActionResult Career()
		{
			return View();
		}

		public IActionResult Projects()
		{
			return View();
		}

		public IActionResult Services()
		{
			return View();
		}

		public IActionResult About()
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
