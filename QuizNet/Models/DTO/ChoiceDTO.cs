using QuizNet.Models.Entities;

namespace QuizNet.Models.DTO;

public class ChoiceDto
{
    public ChoiceText Text { get; set; }
    public bool IsCorrect { get; set; }
}
