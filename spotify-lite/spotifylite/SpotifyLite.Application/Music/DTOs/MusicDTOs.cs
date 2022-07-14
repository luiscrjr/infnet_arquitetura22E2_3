namespace SpotifyLite.Application.Music.DTOs
{
    public record MusicInputDto(string Name, int Duration);
    public record MusicOutputDto(string Name, string Duration);

}