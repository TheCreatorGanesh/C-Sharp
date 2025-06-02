using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cookie_based_authentication.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[Authorize]
		public IActionResult UsersOnly()
		{
			return View();
		}

		[Authorize("Admin")]
		public IActionResult AdminOnly()
		{
			return View();
		}
	}
}
