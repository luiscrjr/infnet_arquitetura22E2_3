
using SpotifyLite.Application.Music.DTOs;

namespace SpotifyLite.Application.User.DTOs
{
    public record UserInputDto(Guid Id, string Name, DateTime DateOfBirth, string Photo, string CPF, string Email, string Password);

    public record UserOutputDto(Guid Id, string Name, DateTime DateOfBirth, string Photo, string CPF, string Email, ICollection<UserFavoriteMusicDto> FavoriteMusics);

    public record UserFavoriteMusicDto(MusicOutputDto music);
}