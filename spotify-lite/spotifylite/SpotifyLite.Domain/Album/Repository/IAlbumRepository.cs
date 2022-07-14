using SpotifyLite.Infrastructure.Database;

namespace SpotifyLite.Domain.Album.Repository
{
    public interface IAlbumRepository : IRepository<Album>
    {
        Task<IEnumerable<Album>> GetAllAlbum();
    }
}
