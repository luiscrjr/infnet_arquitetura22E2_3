using SpotifyLite.Application.Song.DTOs;

namespace SpotifyLite.Application.Album.DTOs
{
    public record AlbumInputDto(Guid Id, string Name, string Band, string Description, string Backdrop, DateTime ReleaseDate, ICollection<SongInputDto> Songs);
    public record AlbumOutputDto(Guid Id, string Name, string Description, string Backdrop, string Band, DateTime ReleaseDate, ICollection<SongOutputDto> Songs);
}