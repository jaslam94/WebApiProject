using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Persistence.Configurations
{
    internal sealed class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasKey(subject => subject.Id);

            builder.Property(subject => subject.Id).ValueGeneratedOnAdd();

            builder.Property(subject => subject.Name).HasMaxLength(60);

            builder.HasMany(subject => subject.Lectures);
        }
    }
}