using Microsoft.OpenApi.Models;

namespace Punicher.Blog.Services.Api.Extensions
{
	/// <summary>
	/// Custom swagger configuration.
	/// </summary>
	internal static class SwaggerExtensions
	{
		#region Methods
		/// <summary>
		/// Adds swagger configuration.
		/// </summary>
		/// <param name="services"><see cref="IServiceCollection"/></param>
		/// <returns><see cref="IServiceCollection"/></returns>
		internal static IServiceCollection AddSwagger(this IServiceCollection services) 
		{
			services.AddEndpointsApiExplorer();

			services.AddSwaggerGen(options =>
			{
				options.SwaggerDoc("v1", new OpenApiInfo
				{
					Version = "v1",
					Title = "Punicher Technology Services API Blog",
					Description = "A simple example ASP.NET Core Web API",
					TermsOfService = null,
					Contact = new OpenApiContact
					{
						Name = "Paco Castillo",
						Email = "punicher@killthemall",
						Url = new Uri("https://killthemall.com")
					},
					License = new OpenApiLicense
					{
						Name = "Use under LICX",
						Url = new Uri("https://example.com/license")
					}
				});
			});

			return services;
		}
		#endregion
	}
}