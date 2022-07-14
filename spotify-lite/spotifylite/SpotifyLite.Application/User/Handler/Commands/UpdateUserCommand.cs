using MediatR;
using SpotifyLite.Application.User.DTOs;

namespace SpotifyLite.Application.User.Handler.Commands
{
    public class UpdateUserCommand : IRequest<UpdateUserCommandResponse>
    {
        public UserInputDto User { get; set; }

        public UpdateUserCommand(UserInputDto user)
        {
            User = user;
        }
    }
}
