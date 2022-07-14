using MediatR;
using SpotifyLite.Application.Album.Handler.Commands;
using SpotifyLite.Application.Album.Handler.Queries;
using SpotifyLite.Application.Album.Services;

namespace SpotifyLite.Application.Album.Handler
{
    public class AlbumHandler : IRequestHandler<CreateAlbumCommand, CreateAlbumCommandResponse>,
                                IRequestHandler<GetAllQueryCommand, GetAllQueryCommandResponse>,
                                IRequestHandler<UpdateAlbumCommand, UpdateAlbumCommandResponse>,
                                IRequestHandler<DeleteAlbumCommand, DeleteAlbumCommandResponse>
    {
        private IAlbumServices albumService;

        public AlbumHandler(IAlbumServices albumService)
        {
            this.albumService = albumService;
        }

        public async Task<CreateAlbumCommandResponse> Handle(CreateAlbumCommand request, CancellationToken cancellationToken)
        {
            var albumDto = await albumService.Create(request.Album);

            return new CreateAlbumCommandResponse(albumDto);
        }

        public async Task<UpdateAlbumCommandResponse> Handle(UpdateAlbumCommand request, CancellationToken cancellationToken)
        {
            var albumDto = await albumService.Update(request.Album);

            return new UpdateAlbumCommandResponse(albumDto);
        }

        public async Task<GetAllQueryCommandResponse> Handle(GetAllQueryCommand request, CancellationToken cancellationToken)
        {
            var albumDto = await albumService.GetAll();

            return new GetAllQueryCommandResponse(albumDto);
        }

        public async Task<DeleteAlbumCommandResponse> Handle(DeleteAlbumCommand request, CancellationToken cancellationToken)
        {
            await albumService.Delete(request.AlbumId);

            return new DeleteAlbumCommandResponse();
        }
    }
}
