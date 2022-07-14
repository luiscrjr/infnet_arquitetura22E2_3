namespace SpotifyLite.Application.Song.DTOs
{
    public record SongInputDto(string Name, int Duration);
    public record SongOutputDto(string Name, string Duration);

}