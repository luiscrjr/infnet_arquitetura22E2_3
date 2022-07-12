using Microsoft.EntityFrameworkCore;
using SpotifyLite.Domain.User;
using SpotifyLite.Domain.User.Repository;
using SpotifyLite.Infrastructure.Database;
using SpotifyLite.Repository.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpotifyLite.Repository.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(SpotifyContext context) : base(context)
        {
        }

        public async Task<ICollection<User>> GetAll()
        {
            return await _set.Include(u => u.FavoriteSongs).ThenInclude(ufs => ufs.Song).ToListAsync();
        }

        public async Task<User> GetUserByPassword(string username, string password)
        {
            return await FindOneByCriteria(x => x.Email.Value == username && x.Password.Value == password);
        }
    }
}