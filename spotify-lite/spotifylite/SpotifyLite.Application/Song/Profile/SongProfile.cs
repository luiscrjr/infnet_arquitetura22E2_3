
using SpotifyLite.Application.Song.DTOs;

namespace SpotifyLite.Application.Song.Profile
{
    public class SongProfile : AutoMapper.Profile
    {
        public SongProfile()
        {
            CreateMap<Domain.Album.Song, SongOutputDto>()
                .ForPath(x => x.Duration, f => f.MapFrom(m => m.Duration.InHoursMinutesAndSeconds));

            CreateMap<SongInputDto, Domain.Album.Song>()
                .ForPath(x => x.Duration.InSeconds, f => f.MapFrom(m => m.Duration));

        }
    }
}