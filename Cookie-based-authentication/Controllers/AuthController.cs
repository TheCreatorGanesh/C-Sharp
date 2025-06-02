using Cookie_based_authentication.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Cookie_based_authentication.Controllers
{
	public class AuthController : Controller
	{
		public IActionResult Login()
		{
			return View();
		}


		[HttpPost]
		public async Task<IActionResult> Login(LoginFormModel model)
		{
			var account = UserManager.Login(model.UserName, model.Password);

			if (account != null)
			{
				var identity = new ClaimsIdentity(account.Claims, Settings.AuthCookieName);
				var principal = new ClaimsPrincipal(identity);

				var properties = new AuthenticationProperties
				{
					IsPersistent = true, // Keep the user logged in across sessions
					ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(30) // Set cookie expiration time
				};

				await HttpContext.SignInAsync(Settings.AuthCookieName, principal, properties);
			}
			else
			{
				return View(model);
			}
			return RedirectToAction("Index", "Home");
		}

		public IActionResult AccessDenied()
		{
			return View();

		}

		[HttpPost]
		public async Task<IActionResult> Logout()
		{
			await HttpContext.SignOutAsync(Settings.AuthCookieName);
			return RedirectToAction("Index", "Home");
		}
	}
}
