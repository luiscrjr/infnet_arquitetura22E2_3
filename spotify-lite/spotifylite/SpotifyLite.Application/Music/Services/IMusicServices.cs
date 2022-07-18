using SpotifyLite.Application.Music.DTOs;

namespace SpotifyLite.Application.Music.Services
{
    public interface IMusicServices
    {
        Task<MusicOutputDto> Create(MusicInputDto MusicDto);
        Task<MusicOutputDto> Update(MusicInputDto MusicDto);
        Task Delete(Guid musicId);
        Task<ICollection<MusicOutputDto>> GetAll();
    }
}