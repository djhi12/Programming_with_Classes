using System;


public class Scripture {
    private string _scriptureVerse;
    private string _referenceVerse;

    public string scriptureDisplay(){
        List<string> _scriptureVerse = new List<string>() {
            "For", "behold", ",", "this", "is", "my", "work", "and", "my", "glory", "-", "to", "bring", "to", "pass", "the", "immortality", "and", "eternal", "life", "of", "man."
        };

        _referenceVerse = "Moses 1:39";

        string scriptureRead = $"{_referenceVerse} {_scriptureVerse}";

        return scriptureRead;
    }
}