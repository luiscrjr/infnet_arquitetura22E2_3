
using SpotifyLite.Application.Song.DTOs;

namespace SpotifyLite.Application.User.DTOs
{
    public record UserDto(Guid Id, string Name, string Band, DateTime DateOfBirth, string Photo, string CPF, string Email, ICollection<SongOutputDto> UserFavoriteSongs);

    public record UserFavoriteSongDto(SongOutputDto song);
}