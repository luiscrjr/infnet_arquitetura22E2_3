using SpotifyLite.Application.User.DTOs;

namespace SpotifyLite.Application.User.Handler.Queries
{
    public class GetAllQueryCommandResponse
    {
        public ICollection<UserDto> Users { get; set; }

        public GetAllQueryCommandResponse(ICollection<UserDto> users)
        {
            Users = users;
        }
    }
}