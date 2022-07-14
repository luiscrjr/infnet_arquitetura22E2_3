using SpotifyLite.Application.User.DTOs;

namespace SpotifyLite.Application.User.Handler.Commands
{
    public class UpdateUserCommandResponse
    {
        public UserOutputDto User { get; set; }

        public UpdateUserCommandResponse(UserOutputDto user)
        {
            User = user;
        }
    }
}