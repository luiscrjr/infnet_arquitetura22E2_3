using SpotifyLite.Application.Music.DTOs;

namespace SpotifyLite.Application.Music.Handler.Commands
{
    public class UpdateMusicCommandResponse
    {
        public MusicOutputDto Music { get; set; }

        public UpdateMusicCommandResponse(MusicOutputDto music)
        {
            music = music;
        }
    }
}