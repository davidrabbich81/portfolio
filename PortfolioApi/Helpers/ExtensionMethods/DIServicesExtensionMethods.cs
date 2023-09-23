using PortfolioApi.Services;
using PortfolioApi.Services.Interface;

namespace PortfolioApi.Helpers.ExtensionMethods
{
    public static class DIServicesExtensionMethods
    {

        public static WebApplicationBuilder? AddDIServices(this WebApplicationBuilder? builder)
        {
            if (builder == null) return null;

            builder.Services.AddScoped<IExperienceService, ExperienceService>();
            builder.Services.AddScoped<IBlogService, BlogService>();

            return builder;
        }


    }
}
