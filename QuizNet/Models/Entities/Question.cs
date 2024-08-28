namespace QuizNet.Models.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public required string Text { get; set; }
        public required Topic Topic { get; set; }
        public string? Image { get; set; }
        public string? Difficulty { get; set; }
        public List<Tag>? Tag { get; set; }
        public List<Choice> Choices { get; set; }

        // I kinda need to think about the best way to do these as True or False
        public bool IsTrueOrFalse { get; set; }
        public bool? CorrectTrueOrFalse { get; set; }
    }
}
