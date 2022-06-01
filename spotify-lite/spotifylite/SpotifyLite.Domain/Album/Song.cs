using SpotifyLite.Domain.Album.ValueObject;

namespace SpotifyLite.Domain.Album
{
    public class Song
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public Duration Duration { get; private set; }

    }
}