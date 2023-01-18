using System;
using System.IO;
using System.Text;

public class AnswerInput
{
    PromptGenerator promptGen = new PromptGenerator();
    DateTime _date = DateTime.Now;
    public string _promptAnswer;
    
   

    public string AnswerDisplay(){
        _promptAnswer = (string.Format("{0} Prompt: {1}", _date, promptGen.displayPrompt()));
        return _promptAnswer;
    }

}