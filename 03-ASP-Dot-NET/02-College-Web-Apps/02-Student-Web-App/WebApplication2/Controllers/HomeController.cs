using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;
using WebApplication2.Service;

namespace WebApplication2.Controllers
{
	public class HomeController : Controller
	{
		// Create a reference to the email service via interface
		private readonly IEmailService _service;
		//private readonly ILogger<HomeController> _logger;

		// Point to provided IEmailService via constructor.
		// DI container will create registered 'EmailService' object to be used by this controller
		public HomeController(IEmailService service)
		{
			_service = service;
		}
		//public HomeController(ILogger<HomeController> logger)
		//{
		//	_logger = logger;
		//}

		public IActionResult Index()
		{
			// Run the service in home page
			_service.SendEmail("Email Message");
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
