using SpotifyLite.Domain.Album;

namespace SpotifyLite.Domain.User
{
    public class UserFavoriteMusic
    {
        public Guid Id { get; set; }

        public virtual Music Music { get; set; }

        public virtual User User { get; set; }
        public virtual DateTime FavoritedAt { get; set; }

    }
}
