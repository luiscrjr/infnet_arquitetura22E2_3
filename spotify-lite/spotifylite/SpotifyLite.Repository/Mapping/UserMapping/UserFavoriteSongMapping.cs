using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpotifyLite.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyLite.Repository.Mapping.UserMapping
{
    public class UserFavoriteSongMapping : IEntityTypeConfiguration<UserFavoriteSong>
    {
        public void Configure(EntityTypeBuilder<UserFavoriteSong> builder)
        {
            builder.ToTable("UserFavoriteSongs");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasOne(x => x.Song).WithMany();
            builder.HasOne(x => x.User).WithMany(x => x.FavoriteSongs);

        }
    }
}
