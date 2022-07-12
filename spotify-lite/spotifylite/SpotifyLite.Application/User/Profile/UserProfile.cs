
using SpotifyLite.Application.Album.DTOs;
using SpotifyLite.Application.User.DTOs;

namespace SpotifyLite.Application.Album.Profile
{
    public class UserProfile : AutoMapper.Profile
    {
        public UserProfile()
        {
            CreateMap<Domain.User.User, UserDto>()
                .ForMember(u => u.CPF, f => f.MapFrom(u => u.CPF.FormatWithPointsAndDots));

            CreateMap<UserDto, Domain.User.User>()
                .ForPath(u => u.CPF.Value, f => f.MapFrom(u => u.CPF));

            CreateMap<UserFavoriteSongDto, Domain.User.UserFavoriteSong>();

            CreateMap<Domain.User.UserFavoriteSong, UserFavoriteSongDto>();

        }
    }
}