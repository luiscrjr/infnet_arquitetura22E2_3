
using SpotifyLite.Application.User.DTOs;

namespace SpotifyLite.Application.User.Profile
{
    public class UserProfile : AutoMapper.Profile
    {
        public UserProfile()
        {
            CreateMap<Domain.User.User, UserOutputDto>()
                .ForPath(u => u.CPF, f => f.MapFrom(u => u.CPF.FormatWithPointsAndDots))
                .ForPath(u => u.Email, f => f.MapFrom(u => u.Email.Value));

            CreateMap<UserInputDto, Domain.User.User>()
                .ForPath(u => u.Password.Value, f => f.MapFrom(u => u.Password))
                .ForPath(u => u.CPF.Value, f => f.MapFrom(u => u.CPF))
                .ForPath(u => u.Email.Value, f => f.MapFrom(u => u.Email));

            CreateMap<UserFavoriteMusicDto, Domain.User.UserFavoriteMusic>();

            CreateMap<Domain.User.UserFavoriteMusic, UserFavoriteMusicDto>();

        }
    }
}