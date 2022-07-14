
using SpotifyLite.Application.Song.DTOs;

namespace SpotifyLite.Application.User.DTOs
{
    public record UserDto(Guid Id, string Name, DateTime DateOfBirth, string Photo, string CPF, string Email, ICollection<UserFavoriteSongDto> FavoriteSongs);

    public record UserFavoriteSongDto(SongOutputDto song);
}