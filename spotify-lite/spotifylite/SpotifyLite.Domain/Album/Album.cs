using SpotifyLite.Domain.Album.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLite.Domain.Album
{
    public class Album
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Backdrop { get; private set; }
        public Band Band { get; private set; }
        public ICollection<Song> Songs {get; private set; }
        
    }
}
