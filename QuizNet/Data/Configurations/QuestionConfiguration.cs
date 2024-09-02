using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuizNet.Models.Entities;

namespace QuizNet.Data.Configurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            // builder.HasKey(x => x.Id);
            // builder.Property(x => x.Text);
            // builder.HasOne(x => x.Topic);
        }
    }
}
