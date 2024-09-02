using System.Reflection;
namespace QuizNet.Models.Entities
{
    public readonly record struct ChoiceID(Guid Value);
    public record struct ChoiceText(string Value);

    public abstract class Choice
    {
        public ChoiceID ID { get; } = new ChoiceID(Guid.NewGuid());
        public required Question Question { get; init; }
        public required ChoiceText Text { get; init; }

        public abstract void Select();
    }

    public class CorrectChoice : Choice
    {
        public override void Select()
        {
            // Handle correct choice selection
        }
    }

    public class IncorrectChoice : Choice
    {
        public override void Select()
        {
            // Handle incorrect choice selection
        }
    }
}
