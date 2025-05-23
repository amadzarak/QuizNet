﻿namespace QuizNet.Models.Entities
{
    public record class Topic
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Color { get; set; }
        public string? Icon { get; set; }
    }
}
