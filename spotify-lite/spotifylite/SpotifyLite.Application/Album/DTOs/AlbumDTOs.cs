using SpotifyLite.Application.Song.DTOs;

namespace SpotifyLite.Application.Album.DTOs
{
    public record AlbumInputDto(string Name, string Band, string Description, string Backdrop, ICollection<SongInputDto> Songs);
    public record AlbumOutputDto(Guid Id, string Name, string Description, string Backdrop, string Band, ICollection<SongOutputDto> Songs);
}