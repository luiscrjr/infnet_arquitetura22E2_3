using SpotifyLite.Domain.Album.ValueObject;

namespace SpotifyLite.Application.Music.DTOs
{
    public record MusicInputDto(Guid Id, string Name, DateTime DateAdded, Duration Duration, Guid AlbumId);
    public record MusicOutputDto(Guid Id, string Name, DateTime DateAdded, Duration Duration, Guid AlbumId);


}