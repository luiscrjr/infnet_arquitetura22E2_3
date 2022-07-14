using SpotifyLite.Application.User.DTOs;

namespace SpotifyLite.Application.User.Services
{
    public interface IUserServices
    {
        Task<UserOutputDto> Create(UserInputDto UserDto);
        Task<UserOutputDto> Update(UserInputDto UserDto);
        Task Delete(Guid userId);
        Task<ICollection<UserOutputDto>> GetAll();
    }
}