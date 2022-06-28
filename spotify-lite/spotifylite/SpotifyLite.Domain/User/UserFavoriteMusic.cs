﻿using SpotifyLite.Domain.Album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLite.Domain.User
{
    public class UserFavoriteMusic
    {
        public Guid Id { get; set; }

        public Music Music { get; set; }
        
        public User User { get; set; }

        public DateTime FavoritedAt { get; set; }

    }
}
