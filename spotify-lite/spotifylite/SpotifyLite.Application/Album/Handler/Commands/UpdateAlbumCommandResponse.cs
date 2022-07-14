using SpotifyLite.Application.Album.DTOs;

namespace SpotifyLite.Application.Album.Handler.Commands
{
    public class UpdateAlbumCommandResponse
    {
        public AlbumOutputDto Album { get; set; }

        public UpdateAlbumCommandResponse(AlbumOutputDto album)
        {
            Album = album;
        }
    }
}