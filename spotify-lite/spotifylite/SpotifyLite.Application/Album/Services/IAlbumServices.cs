using SpotifyLite.Application.Album.DTOs;

namespace SpotifyLite.Application.Album.Services
{
    public interface IAlbumServices
    {
        Task<AlbumOutputDto> Create(AlbumInputDto albumDto);
        Task<AlbumOutputDto> Update(AlbumInputDto albumDto);
        Task Delete(Guid albumId);
        Task<ICollection<AlbumOutputDto>> GetAll();
    }
}