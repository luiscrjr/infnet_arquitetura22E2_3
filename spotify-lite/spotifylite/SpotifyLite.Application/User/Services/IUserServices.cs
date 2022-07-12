using SpotifyLite.Application.Album.DTOs;
using SpotifyLite.Application.User.DTOs;

namespace SpotifyLite.Application.User.Services
{
    public interface IUserServices
    {
        Task<UserDto> Create(UserDto UserDto);
        Task<UserDto> Update(UserDto UserDto);
        Task Delete(Guid userId);
        Task<ICollection<UserDto>> GetAll();
    }
}