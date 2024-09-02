using System;

namespace QuizNet.Models.Entities;

public class QuestionBuilder
{
    public Question _question { get; set; }

    public QuestionBuilder CreateQuestion(string text, Topic topic, List<Choice> choices, string type)
    {
        switch (type)
        {
            case "TrueOrFalse":
                _question = new TrueOrFalseQuestion
                {
                    Text = new QuestionText("True"),
                    Topic = null
                };
                break;
            case "MultipleChoice":
                _question = new MultipleChoiceQuestion
                {
                    Text = new QuestionText("Multiple Choice"),
                    Topic = null
                };
                break;
            default:
                throw new Exception("Invalid question type");
        }
        return this;
    }

}