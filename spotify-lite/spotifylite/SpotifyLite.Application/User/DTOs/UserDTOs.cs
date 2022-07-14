
using SpotifyLite.Application.Song.DTOs;

namespace SpotifyLite.Application.User.DTOs
{
    public record UserInputDto(Guid Id, string Name, DateTime DateOfBirth, string Photo, string CPF, string Email, string Password);

    public record UserOutputDto(Guid Id, string Name, DateTime DateOfBirth, string Photo, string CPF, string Email, ICollection<UserFavoriteSongDto> FavoriteSongs);

    public record UserFavoriteSongDto(SongOutputDto song);
}