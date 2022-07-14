namespace SpotifyLite.Domain.Album.ValueObject
{
    public class Band
    {
        public Band()
        {
        }

        }
        public Band(String name, DateTime dateJoined)
        {
            this.Name = name;
            DateJoined = dateJoined;
        }

        public String Name { get; set; }
        public DateTime DateJoined { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}