namespace SpotifyLite.Domain.Album.ValueObject
{
    public class Band
    {
        public Band(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}