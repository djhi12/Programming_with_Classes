using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
// using System.String;

class Program
{

    static void Main(string[] args)
    {
        
        while (true)
        {

            Console.Write("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");

            int choices = int.Parse(Console.ReadLine());
            PromptGenerator promptGen = new PromptGenerator();
            // inputAnswer inputAnsr = new inputAnswer();

            if (choices == 1) {

                // promptGen.readFile();
                // promptGen.writeFile();
                promptGen.displayPrompt();
            }
            
            else if (choices == 2)
            {


            }

            else if (choices == 3)
            {

            }

            else if (choices == 4)
            {

            }

            else if (choices == 5)
            {
                break;
            }
        }
    }
}
