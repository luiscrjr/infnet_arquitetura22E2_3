using Microsoft.EntityFrameworkCore;
using SpotifyLite.Domain.Album;
using SpotifyLite.Domain.Album.Repository;
using SpotifyLite.Infrastructure.Database;
using SpotifyLite.Repository.Context;
using System.Threading.Tasks;

namespace SpotifyLite.Repository.Repository
{
    public class MusicRepository : Repository<Music>, IMusicRepository
    {
        public MusicRepository(SpotifyContext context) : base(context)
        {
        }


        public async Task Update(Music music)
        {
            _context.Entry(music).State = EntityState.Modified;
            _context.Entry(music.Duration).State = EntityState.Modified;
            _context.Entry(music.Name).State = EntityState.Modified;
            _context.Entry(music.AlbumId).State = EntityState.Modified;
            _set.Update(music);
            await _context.SaveChangesAsync();
        }
    }
}