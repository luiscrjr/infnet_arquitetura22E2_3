using SpotifyLite.Application.Music.DTOs;

namespace SpotifyLite.Application.Music.Handler.Queries
{
    public class GetAllQueryCommandResponse
    {
        public ICollection<MusicOutputDto> Musics { get; set; }

        public GetAllQueryCommandResponse(ICollection<MusicOutputDto> musics)
        {
            Musics = musics;
        }
    }
}