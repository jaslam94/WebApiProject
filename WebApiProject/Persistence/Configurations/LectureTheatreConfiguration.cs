using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Persistence.Configurations
{
    internal sealed class LectureTheatreConfiguration : IEntityTypeConfiguration<LectureTheatre>
    {
        public void Configure(EntityTypeBuilder<LectureTheatre> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id).ValueGeneratedOnAdd();

            builder.Property(m => m.Name).HasMaxLength(60);
        }
    }
}