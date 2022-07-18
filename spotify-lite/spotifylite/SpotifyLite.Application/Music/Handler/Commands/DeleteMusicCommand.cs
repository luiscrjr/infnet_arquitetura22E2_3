using MediatR;

namespace SpotifyLite.Application.Music.Handler.Commands
{
    public class DeleteMusicCommand : IRequest<DeleteMusicCommandResponse>
    {
        public Guid MusicId { get; set; }

        public DeleteMusicCommand(Guid musicId)
        {
            MusicId = musicId;
        }
    }
}