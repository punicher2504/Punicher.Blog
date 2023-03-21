using Punicher.Blog.Services.Api.Extensions;

#region ConfigureServices
//
// Add services to the container.
//
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
	.AddJsonOptions(options => { options.JsonSerializerOptions.PropertyNamingPolicy = null; });
//
// "Custom" service configuration.
//
builder.Services.ConfigureServices();
#endregion

#region Configure
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
#endregion
