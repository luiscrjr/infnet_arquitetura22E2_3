using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SpotifyLite.Application.Album.Services;
using SpotifyLite.Application.User.Services;
using SpotifyLite.Repository;


namespace SpotifyLite.Application
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services, string connectionString)
        {
            services.RegisterRepository(connectionString);

            services.AddAutoMapper(typeof(ConfigurationModule).Assembly);

            services.AddMediatR(typeof(ConfigurationModule).Assembly);

            services.AddScoped<IAlbumServices, AlbumServices>();

            services.AddScoped<IUserServices, UserServices>();

            return services;

        }
    }
}
