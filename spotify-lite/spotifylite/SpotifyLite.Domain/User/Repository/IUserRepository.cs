using SpotifyLite.Infrastructure.Database;

namespace SpotifyLite.Domain.User.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetUserByPassword(string username, string password);
    }
}
