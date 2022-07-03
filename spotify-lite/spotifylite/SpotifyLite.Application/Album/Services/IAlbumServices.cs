using SpotifyLite.Application.Album.DTOs;

namespace SpotifyLite.Application.Album.Services
{
    public interface IAlbumServices
    {
        Task<AlbumOutputDto> Create(AlbumInputDto albumInputDto);
        Task<AlbumOutputDto> Update(AlbumInputDto albumInputDto);
        Task Delete(AlbumInputDto albumInputDto);
        Task<ICollection<AlbumOutputDto>> GetAll();
    }
}