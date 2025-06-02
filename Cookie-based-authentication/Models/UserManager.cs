using System.Security.Claims;

namespace Cookie_based_authentication.Models
{
	public class UserManager
	{
		private static List<UserAccount> _accounts = [
			new UserAccount
			{
				UserName = "admin",
				Password = "admin123",
				Claims = [
					new Claim(ClaimTypes.Name, "admin"),
					new Claim("admin","true"),
					new Claim(ClaimTypes.Role, "Administrator")
				]
			},
			new UserAccount
			{
				UserName = "user",
				Password = "user123",
				Claims =
				[
					new Claim(ClaimTypes.Name, "user"),
					new Claim("admin","false"),
					new Claim(ClaimTypes.Role, "User")
				]
			}
		];

		public static UserAccount Login(String username, string password)
		{
			return _accounts.FirstOrDefault(a =>
			a.UserName == username && a.Password == password
			);
		}
	}

	public class UserAccount
	{
		public string UserName { get; set; }
		public string Password { get; set; }
		public List<Claim> Claims { get; set; }
	}
}
