
using SpotifyLite.Application.Music.DTOs;

namespace SpotifyLite.Application.Music.Profile
{
    public class MusicProfile : AutoMapper.Profile
    {
        public MusicProfile()
        {
            CreateMap<Domain.Album.Music, MusicOutputDto>()
                .ForMember(x => x.Duration, f => f.MapFrom(m => m.Duration.FormatValue));

            CreateMap<MusicInputDto, Domain.Album.Music>()
                .ForPath(x => x.Duration.Value, f => f.MapFrom(m => m.Duration));

        }
    }
}