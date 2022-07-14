using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SpotifyLite.Application.Album.Services;
using SpotifyLite.Repository;


namespace SpotifyLite.Application
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services, string connectionString)
        {
            services.RegisterRepository(connectionString);

            services.AddAutoMapper(typeof(Application.ConfigurationModule).Assembly);

            services.AddMediatR(typeof(Application.ConfigurationModule).Assembly);

            services.AddScoped<IAlbumServices, AlbumServices>();

            return services;

        }
    }
}
