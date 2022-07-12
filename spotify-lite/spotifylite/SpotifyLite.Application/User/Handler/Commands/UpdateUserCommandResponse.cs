using SpotifyLite.Application.User.DTOs;

namespace SpotifyLite.Application.User.Handler.Commands
{
    public class UpdateUserCommandResponse
    {
        public UserDto User { get; set; }

        public UpdateUserCommandResponse(UserDto user)
        {
            User = user;
        }
    }
}