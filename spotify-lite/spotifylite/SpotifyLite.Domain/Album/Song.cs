using SpotifyLite.Domain.Album.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLite.Domain.Album
{
    public class Song
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public Duration Duration { get; private set; }

    }
}
