using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using QuizNet.Models.DTO;

namespace QuizNet.Models.Entities
{
    public class ChoiceCollection : IEnumerable<Choice>
    {
        //public IEnumerable<Choice> ChoicesCollection { get; set; }
        public List<Choice> ChoicesCollection { get; set; } = [];

        public IEnumerator<Choice> GetEnumerator()
        {
            return ChoicesCollection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
    }


    public static class ChoiceFactory {
        public static Choice CreateChoice(string text, bool isCorrect, Question question) {
            return isCorrect ?
                    new CorrectChoice { Text = new ChoiceText(text), Question = question } :
                    new IncorrectChoice { Text = new ChoiceText(text), Question = question };
        }

        public static Choice CreateChoice(ChoiceText text, bool isCorrect, Question question) {
            return isCorrect ?
                    new CorrectChoice { Text = text, Question = question } :
                    new IncorrectChoice { Text = text, Question = question };
        }

        public static ChoiceCollection CreateChoicesFromJSON(string json, Question question) {


            var choices = JsonSerializer.Deserialize<List<ChoiceDto>>(json);
            var choiceCollection = new ChoiceCollection();
            if (choices == null ) { return choiceCollection; }

            foreach (var choice in choices!) {
                choiceCollection.ChoicesCollection.Add(CreateChoice(choice.Text, choice.IsCorrect, question));
            }

            return choiceCollection;
        }

        public static ChoiceCollection CreateTrueOrFalseChoices(TrueOrFalseQuestion question) {
            var choiceCollection = new ChoiceCollection();
            if (question.answer.Value == true) {
                choiceCollection.ChoicesCollection.Add(CreateChoice(new ChoiceText("True"), true, question));
                choiceCollection.ChoicesCollection.Add(CreateChoice(new ChoiceText("False"), false, question));
            } else {
                choiceCollection.ChoicesCollection.Add(CreateChoice(new ChoiceText("True"), false, question));
                choiceCollection.ChoicesCollection.Add(CreateChoice(new ChoiceText("False"), true, question));
            }
            
            return choiceCollection;
        }
    }
}
