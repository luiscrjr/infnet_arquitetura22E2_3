using SpotifyLite.Application.Song.DTOs;

namespace SpotifyLite.Application.Album.DTOs
{
    public record AlbumDto(Guid Id, string Name, string Band, string Description, string Backdrop, DateTime ReleaseDate, ICollection<SongInputDto> Songs);
 }