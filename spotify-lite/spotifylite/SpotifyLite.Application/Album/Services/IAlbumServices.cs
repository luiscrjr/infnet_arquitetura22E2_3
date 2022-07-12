using SpotifyLite.Application.Album.DTOs;

namespace SpotifyLite.Application.Album.Services
{
    public interface IAlbumServices
    {
        Task<AlbumDto> Create(AlbumDto albumDto);
        Task<AlbumDto> Update(AlbumDto albumDto);
        Task Delete(Guid albumId);
        Task<ICollection<AlbumDto>> GetAll();
    }
}