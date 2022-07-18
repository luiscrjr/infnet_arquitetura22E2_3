using MediatR;
using SpotifyLite.Application.Music.DTOs;

namespace SpotifyLite.Application.Music.Handler.Commands
{
    public class UpdateMusicCommand : IRequest<UpdateMusicCommandResponse>
    {
        public MusicInputDto Music { get; set; }

        public UpdateMusicCommand(MusicInputDto music)
        {
            Music = music;
        }
    }
}
