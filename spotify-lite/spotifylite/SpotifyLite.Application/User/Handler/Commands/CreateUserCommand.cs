using MediatR;
using SpotifyLite.Application.User.DTOs;

namespace SpotifyLite.Application.User.Handler.Commands
{
    public class CreateUserCommand : IRequest<CreateUserCommandResponse>
    {
        public UserDto User { get; set; }

        public CreateUserCommand(UserDto user)
        {
            User = user;
        }

    }
}
