using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBase_Adventure.Models;

namespace TextBase_Adventure.Utility
{
    internal class SaveReturnUtillity
    {
        private DataContextUtility _dbContext;
        public SaveReturnUtillity()
        {
            _dbContext = new DataContextUtility();
        }

        public void GetAll()
        {
            List<Save> saves = _dbContext.saves.ToList();

            ConsoleTable table = new ConsoleTable("Id", "Name", "Health", "Location", "Points", "Coins");
            foreach (Save save in saves)
            {
                table.AddRow(save.Id, save.Name, save.Health, save.Location, save.Points, save.Coins);
            }
            table.Write(Format.Alternative);
        }

        public void GetSave()
        {
            GetAll();
            Console.WriteLine("Please type the id of the save you want to get.\n");
            int id = InputCheckUtillity.AskInt("What is the id?");
            Save? save = _dbContext.saves.Find(id);
            if (save is null)
            {
                Console.WriteLine("The record couldn't be found returning to the main menu.\n" +
                    "Press enter to continue.");
                Console.ReadLine();
                return;
            }

            Chapter1 chapter1 = new Chapter1(save);

            switch (save.Location.ToLower())
            {
                case "farm":
                    chapter1.FarmQuest();
                    break;
                case "construction":
                    chapter1.ConstructionQuest();
                    break;
                default:
                    break;
            }
        }
    }
}
