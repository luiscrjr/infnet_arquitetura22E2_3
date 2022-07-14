using SpotifyLite.Domain.Album.ValueObject;

namespace SpotifyLite.Domain.Album
{
    public class Music
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime DateAdded { get; set; }

        public virtual Duration Duration { get; set; }

    }
}
