using System;
using System.Collections.Generic;

public class Scripture
{
    private string _scriptureVerse;
    private string _referenceVerse;

    public string scriptureDisplay()
    {
        Random random = new Random();
        List<string> _scriptureVerse = new List<string>() {
            "For", "behold", ",", "this", "is", "my", "work", "and", "my", "glory", "-", "to", "bring", "to", "pass", "the", "immortality", "and", "eternal", "life", "of", "man."
        };

        foreach (var _scriptureWord in _scriptureVerse)
        {
            if (_scriptureWord == "")
            {

            }
        }



        _referenceVerse = "Moses 1:39";

        string scriptureRead = $"{_referenceVerse} {_scriptureVerse}";

        return scriptureRead;
    }
}