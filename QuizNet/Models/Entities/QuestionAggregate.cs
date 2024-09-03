using System;

namespace QuizNet.Models.Entities;
    public record struct QuestionDifficulty(string Value);
public class QuestionAggregate {
    public Guid Id { get; set; }
    private ChoiceCollection _choices { get; set; } = [];
    public ChoiceCollection Choices { get; set; }
    public QuestionDifficulty? Difficulty { get; set; }
    private Question _question;
    public Question Question => _question;

    public QuestionAggregate(Question question) {
        _question = question;
    }

     public void SetChoicesFromJSON(string json) {
            Choices = ChoiceFactory.CreateChoicesFromJSON(json, this);
        }

    public void AddChoice(Choice choice) {
        _choices.Add(choice);
    }
    
    

}