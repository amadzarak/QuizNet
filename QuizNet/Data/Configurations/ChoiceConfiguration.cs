using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizNet.Models.Entities;

namespace QuizNet.Data.Configurations
{
    public class ChoiceConfiguration : IEntityTypeConfiguration<Choice>
    {
        public void Configure(EntityTypeBuilder<Choice> builder)
        {
            // builder.HasKey(x => x.Id);
            // builder.Property(x => x.Text);
            // builder.Property(x => x.IsCorrect);
            // builder.HasOne(x => x.Question);
        }
    }
}
