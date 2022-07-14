using SpotifyLite.Domain.Album.ValueObject;

namespace SpotifyLite.Domain.Album
{
    public class Album
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public virtual Band Band { get; set; }
        public virtual IList<Music> Musics { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int TotalOfMusics() => Musics.Count;

    }
}