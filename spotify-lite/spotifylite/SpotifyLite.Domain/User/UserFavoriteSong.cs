using SpotifyLite.Domain.Album;

namespace SpotifyLite.Domain.User
{
    public class UserFavoriteSong
    {
        public Guid Id { get; private set; }

        public User User { get; private set; }

        public Song Song { get; private set; }      
    }
}