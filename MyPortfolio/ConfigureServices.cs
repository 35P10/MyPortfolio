using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyPortfolio.Services;

namespace MyPortfolio
{
	public static class ConfigureServices
	{
		public static IServiceCollection AddConfigureServices(this IServiceCollection services, IConfiguration configuration, IWebAssemblyHostEnvironment hostEnvironment)
		{
			services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(hostEnvironment.BaseAddress) });

			services.AddSingleton<ResourcesService>();

			return services;
		}
	}
}
