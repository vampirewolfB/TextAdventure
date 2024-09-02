using Figgle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBase_Adventure.Utility;

namespace TextBase_Adventure
{
    internal class MainMenu
    {
        public MainMenu()
        {
            Run();
        }

        private void Run()
        {
            Console.WriteLine(FiggleFonts.Caligraphy.Render("Welcome By"));
            Console.WriteLine(FiggleFonts.Caligraphy2.Render("Text Adventure"));
            Console.WriteLine("Main menu options:\n" +
                "1. Start a new game.\n" +
                "2. Load a existing game.\n" +
                "3. My achievements.\n" +
                "0. Exit the game.\n");
            int choice = InputCheckUtillity.AskInt("Voer een getal in om een keuze te maken.");

            switch (choice)
            {
                case 1:
                    throw new NotImplementedException();
                    break;
                case 2:
                    throw new NotImplementedException();
                    break;
                case 3:
                    throw new NotImplementedException();
                    break;
                case 0:
                    break;
                default:
                    break;
            }
        }
    }
}
