using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpotifyLite.Domain.Album;

namespace SpotifyLite.Repository.Mapping.AlbumMapping
{
    public class SongMapping : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.ToTable("Songs");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(150);
            builder.Property(x => x.DateAdded).IsRequired();

            builder.OwnsOne(p => p.Duration, f =>
            {
                f.Property(x => x.InSeconds).HasColumnName("Duracao");
            });


        }
    }
}
