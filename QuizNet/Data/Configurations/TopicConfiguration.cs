using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizNet.Models.Entities;

namespace QuizNet.Data.Configurations
{
    public class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            // builder.HasKey(u => u.Id);
            // builder.Property(u => u.Name);
            // builder.Property(u => u.Description);
            // builder.Property(u => u.Icon);
            // builder.Property(u => u.Color);

        }
    }
}
