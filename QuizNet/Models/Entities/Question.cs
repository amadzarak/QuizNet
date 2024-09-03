namespace QuizNet.Models.Entities
{
    public readonly record struct QuestionID(Guid Value);
    public record struct QuestionText(string Value);
    public record struct TrueOrFalseAnswer(bool Value);

    public abstract class Question
    {
        public QuestionID ID = new QuestionID(Guid.NewGuid());
        public required QuestionText Text { get; set; }
        public required Topic Topic { get; set; }
        public string? Image { get; set; }
        
        public List<Tag>? Tag { get; set; }
       
        public QuestionID GetID() => ID;

    }

    public class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseAnswer answer;
        public TrueOrFalseQuestion(bool answer) {
            this.answer = new TrueOrFalseAnswer(answer);
        }

    }

    public class MultipleChoiceQuestion : Question
    {        public MultipleChoiceQuestion() {
        }
    }

    public class FillInTheBlankQuestion : Question
    {

    }


    public class MultipleAnswersQuestion : Question
    {

    }



}
