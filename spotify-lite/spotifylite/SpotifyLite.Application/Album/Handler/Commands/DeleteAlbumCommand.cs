using MediatR;

namespace SpotifyLite.Application.Album.Handler.Commands
{
    public class DeleteAlbumCommand : IRequest<DeleteAlbumCommandResponse>
    {
        public Guid AlbumId { get; set; }

        public DeleteAlbumCommand(Guid albumId)
        {
            AlbumId = albumId;
        }
    }
}
