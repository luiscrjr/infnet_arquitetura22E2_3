
using SpotifyLite.Application.User.DTOs;

namespace SpotifyLite.Application.User.Profile
{
    public class UserProfile : AutoMapper.Profile
    {
        public UserProfile()
        {
            CreateMap<Domain.User.User, UserDto>()
                .ForPath(u => u.CPF, f => f.MapFrom(u => u.CPF.FormatWithPointsAndDots))
                .ForPath(u => u.Email, f => f.MapFrom(u => u.Email.Value));

            CreateMap<UserDto, Domain.User.User>()
                .ForPath(u => u.CPF.Value, f => f.MapFrom(u => u.CPF));

            CreateMap<UserFavoriteSongDto, Domain.User.UserFavoriteSong>();

            CreateMap<Domain.User.UserFavoriteSong, UserFavoriteSongDto>();

        }
    }
}