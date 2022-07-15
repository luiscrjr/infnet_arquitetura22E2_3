
using SpotifyLite.Application.Music.DTOs;

namespace SpotifyLite.Application.UserFavoriteMusic.DTOs
{
    public record UserInputDto(Guid Id, string Name);

    public record UserOutputDto(Guid Id, string Name, ICollection<UserFavoriteMusicDto> FavoriteMusics);

    public record UserFavoriteMusicDto(MusicOutputDto music);
}