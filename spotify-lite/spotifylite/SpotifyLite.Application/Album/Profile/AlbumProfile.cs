
using SpotifyLite.Application.Album.DTOs;

namespace SpotifyLite.Application.Album.Profile
{
    public class AlbumProfile : AutoMapper.Profile
    {
        public AlbumProfile()
        {
            CreateMap<Domain.Album.Album, AlbumOutputDto>()
                .ForMember(x => x.Band, f => f.MapFrom(m => m.Band.Name))
                .ForMember(x => x.BandDateJoined, f => f.MapFrom(m => m.Band.DateJoined));

            CreateMap<AlbumInputDto, Domain.Album.Album>()
                .ForPath(x => x.Band.Name, f => f.MapFrom(m => m.Band))
                .ForPath(x => x.Band.DateJoined, f => f.MapFrom(m => m.BandDateJoined));

        }
    }
}