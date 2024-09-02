namespace QuizNet.Models.Entities
{
    public readonly record struct QuestionID(Guid Value);
    public record struct QuestionText(string Value);
    public record struct TrueOrFalseAnswer(bool Value);
    public record struct QuestionDifficulty(string Value);
    public abstract class Question
    {
        public QuestionID ID = new QuestionID(Guid.NewGuid());
        public required QuestionText Text { get; set; }
        public required Topic Topic { get; set; }
        public string? Image { get; set; }
        public QuestionDifficulty? Difficulty { get; set; }
        public List<Tag>? Tag { get; set; }
        public ChoiceCollection Choices { get; set; } = [];

        public QuestionID GetID() => ID;

        public void SetChoicesFromJSON(string json) {
            Choices = ChoiceFactory.CreateChoicesFromJSON(json, this);
        }

        public void CreateQuestionFromJSON(string json) {}

    }

    public class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseAnswer answer;
        public TrueOrFalseQuestion(bool answer) {
            this.answer = new TrueOrFalseAnswer(answer);
            Choices = ChoiceFactory.CreateTrueOrFalseChoices(this);
        }

    }

    public class MultipleChoiceQuestion : Question
    {        public MultipleChoiceQuestion() {
            Choices = new ChoiceCollection();
        }
    }

    public class FillInTheBlankQuestion : Question
    {

    }


    public class MultipleAnswersQuestion : Question
    {

    }



}
