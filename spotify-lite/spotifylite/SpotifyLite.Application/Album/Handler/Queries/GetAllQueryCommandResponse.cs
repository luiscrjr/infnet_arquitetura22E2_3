using SpotifyLite.Application.Album.DTOs;

namespace SpotifyLite.Application.Album.Handler.Queries
{
    public class GetAllQueryCommandResponse
    {
        public ICollection<AlbumDto> Albums { get; set; }

        public GetAllQueryCommandResponse(ICollection<AlbumDto> albums)
        {
            Albums = albums;
        }
    }
}