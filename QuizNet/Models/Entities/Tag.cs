namespace QuizNet.Models.Entities
{
    public record class Tag
    {
        public int Id { get; set; }
        public string Text { get; init; }
        public string Icon { get; set; }
        public string Color { get; set; }


    }
}
