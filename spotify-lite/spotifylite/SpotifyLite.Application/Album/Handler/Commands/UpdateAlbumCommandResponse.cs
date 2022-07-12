using SpotifyLite.Application.Album.DTOs;

namespace SpotifyLite.Application.Album.Handler.Commands
{
    public class UpdateAlbumCommandResponse
    {
        public AlbumDto Album { get; set; }

        public UpdateAlbumCommandResponse(AlbumDto album)
        {
            Album = album;
        }
    }
}