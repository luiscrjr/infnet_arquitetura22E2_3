using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpotifyLite.Domain.Album;

namespace SpotifyLite.Repository.Mapping.AlbumMapping
{
    public class MusicMapping : IEntityTypeConfiguration<Music>
    {
        public void Configure(EntityTypeBuilder<Music> builder)
        {
            builder.ToTable("Musics");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(150);
            builder.Property(x => x.DateAdded).IsRequired();

            builder.OwnsOne(p => p.Duration, f =>
            {
                f.Property(x => x.Value).HasColumnName("Duracao");
            });


        }
    }
}
