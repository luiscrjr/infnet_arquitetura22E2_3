using MediatR;
using SpotifyLite.Application.Album.DTOs;

namespace SpotifyLite.Application.Album.Handler.Commands
{
    public class UpdateAlbumCommand : IRequest<UpdateAlbumCommandResponse>
    {
        public AlbumDto Album { get; set; }

        public UpdateAlbumCommand(AlbumDto album)
        {
            Album = album;
        }

    }
}
