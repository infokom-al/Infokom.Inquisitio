using Infokom.Inquisitio.Application.Extensions;
using Infokom.Inquisitio.Apps.Web.Dashboard.Components;

namespace Infokom.Inquisitio.Apps.Web.Dashboard
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);


			// Add services to the container.
			builder.Services.AddApplicationServices(builder.Configuration);

			

			builder.Services.AddBlazorBootstrap();

			builder.Services.AddRazorComponents()
			    .AddInteractiveServerComponents();

			builder.Services.AddQuickGridEntityFrameworkAdapter();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Error");
				app.UseHsts();
				app.UseMigrationsEndPoint();
			}

			app.UseHttpsRedirection();

			app.UseAntiforgery();

			app.MapStaticAssets();
			app.MapRazorComponents<App>()
			    .AddInteractiveServerRenderMode();

			app.Run();
		}
	}
}
