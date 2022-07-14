using SpotifyLite.Application.Album.DTOs;

namespace SpotifyLite.Application.Album.Handler.Commands
{
    public class CreateAlbumCommandResponse
    {
        public AlbumOutputDto Album { get; set; }

        public CreateAlbumCommandResponse(AlbumOutputDto album)
        {
            Album = album;
        }
    }
}
