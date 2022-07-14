using MediatR;
using SpotifyLite.Application.User.DTOs;

namespace SpotifyLite.Application.User.Handler.Commands
{
    public class CreateUserCommand : IRequest<CreateUserCommandResponse>
    {
        public UserInputDto User { get; set; }

        public CreateUserCommand(UserInputDto user)
        {
            User = user;
        }

    }
}
