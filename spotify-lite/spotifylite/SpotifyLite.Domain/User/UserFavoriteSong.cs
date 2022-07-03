using SpotifyLite.Domain.Album;

namespace SpotifyLite.Domain.User
{
    public class UserFavoriteSong
    {
        public Guid Id { get; private set; }

        public virtual User User { get; private set; }

        public virtual Song Song { get; private set; }
    }
}