using System;

namespace Program
{

    class Main
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person._givenName = "Joseph";
            person._familyName = "Smith";
            person.ShowWesternName();
            person.ShowEasternName();
        }
    }
}