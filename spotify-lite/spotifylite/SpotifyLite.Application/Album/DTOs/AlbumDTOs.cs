using SpotifyLite.Application.Music.DTOs;

namespace SpotifyLite.Application.Album.DTOs
{
    public record AlbumInputDto(Guid Id, string Name, string Band, string Description, DateTime ReleaseDate, DateTime BandDateJoined, ICollection<MusicInputDto> Musics);
    public record AlbumOutputDto(Guid Id, string Name, string Band, string Description, DateTime ReleaseDate, DateTime BandDateJoined, ICollection<MusicOutputDto> Musics);
}