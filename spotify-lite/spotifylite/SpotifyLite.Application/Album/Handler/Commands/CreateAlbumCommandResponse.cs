using SpotifyLite.Application.Album.Dto;

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
