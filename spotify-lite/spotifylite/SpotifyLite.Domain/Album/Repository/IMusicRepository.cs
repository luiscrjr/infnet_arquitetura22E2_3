using SpotifyLite.Infrastructure.Database;

namespace SpotifyLite.Domain.Album.Repository
{
    public interface IMusicRepository : IRepository<Music>
    {
        Task Update(Music music);
    }
}
