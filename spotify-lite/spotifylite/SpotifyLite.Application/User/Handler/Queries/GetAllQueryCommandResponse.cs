using SpotifyLite.Application.User.DTOs;

namespace SpotifyLite.Application.User.Handler.Queries
{
    public class GetAllQueryCommandResponse
    {
        public ICollection<UserOutputDto> Users { get; set; }

        public GetAllQueryCommandResponse(ICollection<UserOutputDto> users)
        {
            Users = users;
        }
    }
}