using MediatR;
using SpotifyLite.Application.Album.DTOs;

namespace SpotifyLite.Application.Album.Handler.Commands
{
    public class UpdateAlbumCommand : IRequest<UpdateAlbumCommandResponse>
    {
        public AlbumInputDto Album { get; set; }

        public UpdateAlbumCommand(AlbumInputDto album)
        {
            Album = album;
        }

    }
}
