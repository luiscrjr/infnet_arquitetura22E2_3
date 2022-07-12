using MediatR;
using SpotifyLite.Application.Album.DTOs;

namespace SpotifyLite.Application.Album.Handler.Commands
{
    public class CreateAlbumCommand : IRequest<CreateAlbumCommandResponse>
    {
        public AlbumDto Album { get; set; }

        public CreateAlbumCommand(AlbumDto album)
        {
            Album = album;
        }

    }
}
