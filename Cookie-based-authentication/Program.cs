using Cookie_based_authentication;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication()
	.AddCookie(Settings.AuthCookieName, options =>
	{
		options.LoginPath = "/Auth/Login";
		options.LogoutPath = "/Auth/Logout";
		options.AccessDeniedPath = "/Auth/AccessDenied";
	});

builder.Services.AddAuthorization(options =>
{
	options.AddPolicy("Admin", policy => policy.RequireClaim("admin", "true"));
	options.AddPolicy("User", policy => policy.RequireClaim("admin", "false"));
});

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}"
);

app.Run();
