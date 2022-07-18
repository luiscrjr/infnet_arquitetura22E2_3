using SpotifyLite.Application.Music.DTOs;

namespace SpotifyLite.Application.Music.Handler.Commands
{
    public class CreateMusicCommandResponse
    {
        public MusicOutputDto Music { get; set; }

        public CreateMusicCommandResponse(MusicOutputDto music)
        {
            Music = music;
        }
    }
}
