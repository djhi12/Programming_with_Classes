using System;
using System.IO;
using System.Text;

public class PromptGenerator
{
    public string _promptQuestions;

   

    public void displayPrompt(){
        var _promptQuestions = new List<string>() {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random randQuestion = new Random();
        int indexQuestion = randQuestion.Next(0, _promptQuestions.Count());
        Console.Write($"{_promptQuestions[indexQuestion]}\n");
    }
  

}