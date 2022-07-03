using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpotifyLite.Domain.User;

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
