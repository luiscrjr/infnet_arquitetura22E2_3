using SpotifyLite.Application.Album.DTOs;

namespace SpotifyLite.Application.Album.Handler.Queries
{
    public class GetAllQueryCommandResponse
    {
        public ICollection<AlbumOutputDto> Albums { get; set; }

        public GetAllQueryCommandResponse(ICollection<AlbumOutputDto> albums)
        {
            Albums = albums;
        }
    }
}