
using SpotifyLite.Application.Album.DTOs;

namespace SpotifyLite.Application.Album.Profile
{
    public class AlbumProfile : AutoMapper.Profile
    {
        public AlbumProfile()
        {
            CreateMap<Domain.Album.Album, AlbumOutputDto>()
                .ForMember(x => x.Band, f => f.MapFrom(m => m.Band.Name));

            CreateMap<AlbumInputDto, Domain.Album.Album>()
                .ForPath(x => x.Band.Name, f => f.MapFrom(m => m.Band));

        }
    }
}