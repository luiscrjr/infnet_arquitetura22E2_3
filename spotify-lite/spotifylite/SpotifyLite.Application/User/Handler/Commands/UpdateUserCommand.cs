using MediatR;
using SpotifyLite.Application.User.DTOs;

namespace SpotifyLite.Application.User.Handler.Commands
{
    public class UpdateUserCommand : IRequest<UpdateUserCommandResponse>
    {
        public UserDto User { get; set; }

        public UpdateUserCommand(UserDto user)
        {
            User = user;
        }
    }
}
