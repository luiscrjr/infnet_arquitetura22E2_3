using MediatR;

namespace SpotifyLite.Application.Album.Handler.Queries
{
    public class GetAllQueryCommand : IRequest<GetAllQueryCommandResponse>
    {
    }
}