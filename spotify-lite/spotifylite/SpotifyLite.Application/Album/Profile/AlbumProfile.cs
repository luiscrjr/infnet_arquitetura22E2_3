
using SpotifyLite.Application.Album.DTOs;
using SpotifyLite.Application.Song.DTOs;

namespace SpotifyLite.Application.Album.Profile
{
    public class AlbumProfile : AutoMapper.Profile
    {
        public AlbumProfile()
        {
            CreateMap<Domain.Album.Song, SongOutputDto>()
                .ForMember(x => x.Duration, f => f.MapFrom(m => m.Duration.InHoursMinutesAndSeconds));

            CreateMap<SongInputDto, Domain.Album.Song>()
                .ForPath(x => x.Duration.InSeconds, f => f.MapFrom(m => m.Duration));

            CreateMap<Domain.Album.Album, AlbumOutputDto>()
                .ForMember(x => x.Band, f => f.MapFrom(m => m.Band.Name));

            CreateMap<AlbumInputDto, Domain.Album.Album>()
                .ForPath(x => x.Band.Name, f => f.MapFrom(m => m.Band));

        }

    }
}