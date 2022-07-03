using MediatR;
using SpotifyLite.Application.Album.DTOs;

namespace SpotifyLite.Application.Album.Handler.Queries
{
    public class GetAllQueryCommand : IRequest<GetAllQueryCommandResponse>
    {
    }
}