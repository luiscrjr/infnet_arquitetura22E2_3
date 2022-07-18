using Microsoft.EntityFrameworkCore;
using SpotifyLite.Domain.Album;
using SpotifyLite.Domain.Album.Repository;
using SpotifyLite.Infrastructure.Database;
using SpotifyLite.Repository.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SpotifyLite.Repository.Repository
{
    public class AlbumRepository : Repository<Album>, IAlbumRepository
    {
        public AlbumRepository(SpotifyContext context) : base(context)
        {
        }

        public async Task<ICollection<Album>> GetAll()
        {
            return await _set.Include(a => a.Musics).ToListAsync();
        }

        public async Task Update(Album album)
        {
            _context.Entry(album).State = EntityState.Modified;
            _context.Entry(album.Band).State = EntityState.Modified;
            _set.Update(album);
            await _context.SaveChangesAsync();
        }
    }
}