using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SpotifyLite.Domain.Album.Repository;
using SpotifyLite.Domain.User.Repository;
using SpotifyLite.Repository.Context;
using SpotifyLite.Repository.Repository;

namespace SpotifyLite.Repository
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionString)
        {

            services.AddDbContext<SpotifyContext>(c =>
            {
                c.UseSqlServer(connectionString);
            });

            services.AddScoped<IAlbumRepository, AlbumRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IMusicRepository, MusicRepository>();

            return services;

        }
    }
}
