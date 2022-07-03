using SpotifyLite.Domain.Album.ValueObject;

namespace SpotifyLite.Domain.Album
{
    public class Song
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public virtual Duration Duration { get; private set; }
    }
}