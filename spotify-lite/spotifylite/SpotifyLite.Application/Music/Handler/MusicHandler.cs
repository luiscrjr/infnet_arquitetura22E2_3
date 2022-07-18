using MediatR;
using SpotifyLite.Application.Music.Handler.Commands;
using SpotifyLite.Application.Music.Handler.Queries;
using SpotifyLite.Application.Music.Services;

namespace SpotifyLite.Application.Music.Handler
{
    public class MusicHandler : IRequestHandler<CreateMusicCommand, CreateMusicCommandResponse>,
                                IRequestHandler<GetAllQueryCommand, GetAllQueryCommandResponse>,
                                IRequestHandler<UpdateMusicCommand, UpdateMusicCommandResponse>,
                                IRequestHandler<DeleteMusicCommand, DeleteMusicCommandResponse>
    {
        private IMusicServices musicService;

        public MusicHandler(IMusicServices musicService)
        {
            this.musicService = musicService;
        }

        public async Task<CreateMusicCommandResponse> Handle(CreateMusicCommand request, CancellationToken cancellationToken)
        {
            var musicDto = await musicService.Create(request.Music);

            return new CreateMusicCommandResponse(musicDto);
        }

        public async Task<UpdateMusicCommandResponse> Handle(UpdateMusicCommand request, CancellationToken cancellationToken)
        {
            var musicDto = await musicService.Update(request.Music);

            return new UpdateMusicCommandResponse(musicDto);
        }

        public async Task<GetAllQueryCommandResponse> Handle(GetAllQueryCommand request, CancellationToken cancellationToken)
        {
            var musicDto = await musicService.GetAll();

            return new GetAllQueryCommandResponse(musicDto);
        }

        public async Task<DeleteMusicCommandResponse> Handle(DeleteMusicCommand request, CancellationToken cancellationToken)
        {
            await musicService.Delete(request.MusicId);

            return new DeleteMusicCommandResponse();
        }
    }
}