using MediatR;
using SpotifyLite.Application.Album.Dto;

namespace SpotifyLite.Application.Album.Handler.Query
{
    public class GetAllQueryCommand : IRequest<GetAllQueryCommandResponse>
    {

    }

    public class GetAllQueryCommandResponse
    {
        public List<AlbumOutputDto> Albums { get; set; }

        public GetAllQueryCommandResponse()
        {

        }

        public GetAllQueryCommandResponse(List<AlbumOutputDto> albuns)
        {
            this.Albums = albuns;
        }
    }
}
