using Figgle;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        // Main menu selection pannel
        private void Run()
        {
            bool run = true;

            while (run)
            {
                Console.Clear();
                Console.WriteLine(FiggleFonts.Caligraphy.Render("Welcome By"));
                Console.WriteLine(FiggleFonts.Caligraphy2.Render("Text Adventure"));
                Console.WriteLine("Main menu options:\n" +
                    "1. Start a new game.\n" +
                    "2. Load a existing game.\n" +
                    "3. My achievements.\n" +
                    "0. Exit the game.\n");
                int choice = InputCheckUtillity.AskInt("Voer een getal in om een keuze te maken.");

                Console.Clear();
                SaveReturnUtillity saveReturnUtillity = new SaveReturnUtillity();

                switch (choice)
                {
                    case 1:
                        Chapter1 chapter1 = new Chapter1();
                        chapter1.Start();
                        break;
                    case 2:
                        saveReturnUtillity.GetSave();
                        break;
                    case 3:
                        saveReturnUtillity.GetAll();
                        Console.WriteLine("Press enter to go back to the main menu.");
                        Console.ReadLine();
                        break;
                    case 0:
                        run = false;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(FiggleFonts.Caligraphy.Render("Thank you"));
            Console.WriteLine(FiggleFonts.Caligraphy2.Render("for playing"));
        }
    }
}
