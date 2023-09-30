using PortfolioApi.Helpers.ExtensionMethods;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen((options) =>
{
    options.CustomOperationIds(e =>
    {
        return $"{e.HttpMethod}_{e.ActionDescriptor.RouteValues["controller"]}_{e.ActionDescriptor.RouteValues["action"]}";
    });

    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
    {
        Version = "v1",
        Title = "David Rabbich portfolio API",
        Description = "Provides extended functionality for the portfolio website",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact() { 
            Name = "David Rabbich", 
            Email = "david@rabbich.dev" 
        }
    });
    
    // add the XML docs
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath);


});

// add dependency injection services
builder.AddDIServices();

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

app.UseCors((x) =>
{
    x.AllowAnyOrigin();
});

app.Run();


