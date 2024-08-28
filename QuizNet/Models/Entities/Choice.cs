namespace QuizNet.Models.Entities
{
    public record class Choice
    {
        public int Id { get; set; }
        public required Question Question { get; set; }
        public required string Text { get; set; }
        public required bool IsCorrect { get; set; }
        
    }
}
