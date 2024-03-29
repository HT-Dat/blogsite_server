using BLL.Services;
using BLL.Services.IServices;
using BLL.Utilities;
using BLL.Utilities.AutoMapperProfiles;
using DAL.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BLL;

public static class DependencyInjection
{
    public static void RegisterBllDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAutoMapper(typeof(AutoMapperProfiles));
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IPostService, PostService>();
        services.AddScoped<ISystemClock, SystemClock>();
        services.AddScoped<IImageService, ImageService>();
        services.AddScoped<ITimeHelper, TimeHelper>();
        services.AddScoped<IBlogSiteDbContext>(provider => provider.GetRequiredService<BlogSiteDbContext>());
    }
}