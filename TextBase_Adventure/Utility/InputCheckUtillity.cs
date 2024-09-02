using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBase_Adventure.Utility
{
    internal class InputCheckUtillity
    {
        // Function to ask a user for a non nullable string.
        internal static string AskString(string question)
        {
            string? userInput = "";

            while ((userInput is null || userInput == ""))
            {
                Console.WriteLine(question);
                userInput = Console.ReadLine();
            }

            return userInput;
        }

        // FUnction to ask a user for a non nullable interger.
        internal static int AskInt(string question)
        {
            int retVal;
            string userInput = "";

            while (!int.TryParse(userInput, out retVal))
            {
                userInput = AskString(question);
            }

            return retVal;
        }
    }
}
