using SpotifyLite.Application.Album.DTOs;

namespace SpotifyLite.Application.Album.Handler.Commands
{
    public class CreateAlbumCommandResponse
    {
        public AlbumDto Album { get; set; }

        public CreateAlbumCommandResponse(AlbumDto album)
        {
            Album = album;
        }
    }
}
