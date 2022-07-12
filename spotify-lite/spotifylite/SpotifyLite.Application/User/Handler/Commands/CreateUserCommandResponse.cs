using SpotifyLite.Application.Album.DTOs;
using SpotifyLite.Application.User.DTOs;

namespace SpotifyLite.Application.User.Handler.Commands
{
    public class CreateUserCommandResponse
    {
        public UserDto User { get; set; }

        public CreateUserCommandResponse(UserDto user)
        {
            User = user;
        }
    }
}
