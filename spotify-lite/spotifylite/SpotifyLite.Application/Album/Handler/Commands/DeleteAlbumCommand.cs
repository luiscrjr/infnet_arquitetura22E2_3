using MediatR;
using SpotifyLite.Application.Album.DTOs;

namespace SpotifyLite.Application.Album.Handler.Commands
{
    public class DeleteAlbumCommand : IRequest<DeleteAlbumCommandResponse>
    {
        public AlbumInputDto Album { get; set; }

        public DeleteAlbumCommand(AlbumInputDto album)
        {
            Album = album;
        }

    }
}
