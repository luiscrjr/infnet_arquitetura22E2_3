using MediatR;
using SpotifyLite.Application.User.Handler.Commands;
using SpotifyLite.Application.User.Handler.Queries;
using SpotifyLite.Application.User.Services;

namespace SpotifyLite.Application.User.Handler
{
    public class UserHandler : IRequestHandler<CreateUserCommand, CreateUserCommandResponse>,
                                IRequestHandler<GetAllQueryCommand, GetAllQueryCommandResponse>,
                                IRequestHandler<UpdateUserCommand, UpdateUserCommandResponse>,
                                IRequestHandler<DeleteUserCommand, DeleteUserCommandResponse>
    {
        private IUserServices userService;

        public UserHandler(IUserServices userService)
        {
            this.userService = userService;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var userDto = await userService.Create(request.User);

            return new CreateUserCommandResponse(userDto);
        }

        public async Task<UpdateUserCommandResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var userDto = await userService.Update(request.User);

            return new UpdateUserCommandResponse(userDto);
        }

        public async Task<GetAllQueryCommandResponse> Handle(GetAllQueryCommand request, CancellationToken cancellationToken)
        {
            var userDto = await userService.GetAll();

            return new GetAllQueryCommandResponse(userDto);
        }

        public async Task<DeleteUserCommandResponse> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            await userService.Delete(request.UserId);

            return new DeleteUserCommandResponse();
        }
    }
}