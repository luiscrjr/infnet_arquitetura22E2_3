namespace SpotifyLite.Application.Album.Dto
{
    public record AlbumInputDto(string Name, string Band, string Description, List<MusicInputDto> Musics);
    public record AlbumOutputDto(Guid Id, string Name, string Description, string Band, List<MusicOutputDto> Musics);
    public record MusicInputDto(String Name, int Duration);
    public record MusicOutputDto(String Name, string Duration);

}