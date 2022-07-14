using MediatR;

namespace SpotifyLite.Application.User.Handler.Commands
{
    public class DeleteUserCommand : IRequest<DeleteUserCommandResponse>
    {
        public Guid UserId { get; set; }

        public DeleteUserCommand(Guid userId)
        {
            UserId = userId;
        }
    }
}