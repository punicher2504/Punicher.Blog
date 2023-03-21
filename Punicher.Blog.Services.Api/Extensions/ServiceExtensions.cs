namespace Punicher.Blog.Services.Api.Extensions
{
	/// <summary>
	/// Configuration of services in the web api.
	/// </summary>
	internal static class ServiceExtensions
	{
		#region Methods
		/// <summary>		
		/// Configure the necessary services in the web api.
		/// </summary>
		/// <param name="services"><see cref="IServiceCollection"/></param>
		internal static void ConfigureServices(this IServiceCollection services)
		{
			services.AddSwagger();
		}
		#endregion
	}
}