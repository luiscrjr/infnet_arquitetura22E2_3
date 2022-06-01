using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLite.Domain.Album.ValueObject
{
    public class Band
    {
        public Band()
        {
        }

        public Band(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
