using MediatR;

namespace SpotifyLite.Application.Music.Handler.Queries
{
    public class GetAllQueryCommand : IRequest<GetAllQueryCommandResponse>
    {
    }
}