using MediatR;
using SpotifyLite.Application.Music.DTOs;

namespace SpotifyLite.Application.Music.Handler.Commands
{
    public class CreateMusicCommand : IRequest<CreateMusicCommandResponse>
    {
        public MusicInputDto Music { get; set; }

        public CreateMusicCommand(MusicInputDto music)
        {
            Music = music;
        }

    }
}
