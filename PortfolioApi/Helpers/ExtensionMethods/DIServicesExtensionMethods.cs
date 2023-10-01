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
            builder.Services.AddScoped<IFileService, FileService>();
            builder.Services.AddScoped<IMarkdownConverterService, MarkdownConverterService>();

            return builder;
        }


    }
}
