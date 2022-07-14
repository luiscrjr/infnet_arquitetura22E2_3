using SpotifyLite.Application.User.DTOs;

namespace SpotifyLite.Application.User.Handler.Commands
{
    public class CreateUserCommandResponse
    {
        public UserOutputDto User { get; set; }

        public CreateUserCommandResponse(UserOutputDto user)
        {
            User = user;
        }
    }
}
