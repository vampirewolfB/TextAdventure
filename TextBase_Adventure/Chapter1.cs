using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBase_Adventure.Models;
using TextBase_Adventure.Utility;

namespace TextBase_Adventure
{
    internal class Chapter1
    {
        private Save _save;
        private DataContextUtility _dbContext;
        public Chapter1()
        {
            _save = new Save();
            _dbContext = new DataContextUtility();
        }

        public Chapter1(Save save)
        {
            this._save = save;
            _dbContext = new DataContextUtility();
        }

        // Start of the story
        public void Start()
        {
            Console.WriteLine("Guide Spirit:\n" +
                "   Good day adventurer by your journy trough the lands of text.\n" +
                "   I will be your guide trough the story if you are stuck you can always ask for help.\n" +
                "   How about let's try it out now? Type in 'help' to get help and see your goal.");
            string? help = Console.ReadLine();
            Console.Clear();

            if (help.ToLower(System.Globalization.CultureInfo.CurrentCulture) != "help" || help is null)
            {
                Console.WriteLine("Guide Spirit:\n" +
                    "   Oh well seems like you don't apreciate the help. Good luck not playing this game.\n" +
                    "   Press enter to go back to the main menu.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Guide Spirit:\n" +
                "   Your goal is to become a adventurer how high is fully up to you.\n" +
                "   So let's not waste time and go the adventure guild and register.\n" +
                "   Type 'go' to go the adventurer guild.");

            string? go = Console.ReadLine();
            Console.Clear();

            if (!go.Equals("go", StringComparison.CurrentCultureIgnoreCase) || go is null)
            {
                Console.WriteLine("Guide Spirit:\n" +
                    "   Oh well seems like you don't want to become a adventurer. Good luck not playing this game.\n" +
                    "   Press enter to go back to the main menu.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("After a short walk you arrive at the adventurers guild.\n" +
                "You enter in a big hall with a lot of diffrent people.\n" +
                "At your right you see a reception and you decided to walk to it.\n\n" +
                "Receptionist:\n" +
                "   Good day I haven't seen you around before. How can I help you?\n" +
                "You:\n" +
                "   Hello I would like to register as a adventurer.\n" +
                "Receptionist:");
            _save.Name = InputCheckUtillity.AskString("   Certainly please write here your name");

            Console.WriteLine("Receptionist:\n" +
               $"   Once again welcome {_save.Name} and thank you for registering there is 1 more thing.\n" +
                "   Please touch the crystal over there to see what you stats are.\n" +
                "You go touch the crystal that was being presented.\n" +
                "Receptionist:\n" +
                "   Wow those stats are all very balanced we do have high hopes for you.\n" +
                "You:\n" +
                "   Thank you for the compliment I certainly hope to live up to expectations then.\n" +
                "Receptionist:\n" +
                "   That was all give me a min to get your adventurer card.\n" +
                "After waiting a few at desk she returns.\n" +
                "Receptionist:\n" +
                "   Here you go make sure you don't lose it as this proves you are a adventurer.\n" +
                "   I will now explain how things work.\n" +
                "   Also sorry but I still have not given my name yet.\n" +
                "   I am Lilly you can accept quests by coming to me.\n" +
                "   For each complete event or quest you will get points.\n" +
                "   The more points you get the higher rank you will be.\n" +
                "   The amount of points you get will be decided on a lot of things.\n" +
                "   Like the rank of the quests, speed and quallity.\n" +
                "   Is everything so far clear?\n" +
                "You:\n" +
                "   Yes are there any other things I should know?\n" +
                "Lilly:\n" +
                "   Nope that should have been all for the explenation.\n" +
                "   The quest board is there as your current rank is F you can only take basic quests.\n" +
                "You:\n" +
                "   Thank you I will go take a look.\n" +
                "You walk towards the quest board and see all kind of quests.\n" +
                "While looking trough to find a good first quest to start earning money you spot a lot of dangerous looking ones.\n" +
                "Till at some point you see 2 quests that catches your eyes for your current rank.\n" +
                "1. A quests to help on a farm to harvest some crops. Reward 5 points and 10 Coins\n" +
                "2. A quests to help on a construction site. Reward 5 points and 10 Coins\n" +
                "Both of these days are 1 day work.");
            int choice = 0;
            while (true)
            {
                choice = InputCheckUtillity.AskInt("Please choose the number of the quest you want to do.");
                if(choice == 1|| choice == 2)
                {
                    break;
                }
            }
            Console.WriteLine("Guide Spirit:\n" +
                "   Now we got everything covered and made the first choice.\n" +
                "   Let's save your progress.\n" +
                "   You can press enter to go on with the storry");
            
            _save.Points = 0;
            _save.Coins = 0;
            _save.Health = 100;

            switch (choice)
            {
                case 1:
                    _save.Location = "Farm";
                    _dbContext.Add(_save);
                    _dbContext.SaveChanges();
                    Console.ReadLine();
                    Console.Clear();
                    FarmQuest();
                    break;
                case 2:
                    _save.Location = "Construction";
                    _dbContext.Add(_save);
                    _dbContext.SaveChanges();
                    Console.ReadLine();
                    Console.Clear();
                    ConstructionQuest();
                    break;
                default:
                    break;
            }
        }

        // Option 1 of the story to work on a farm
        public void FarmQuest()
        {
            Console.WriteLine("You took the farm quest from the board and went back to the reception desk.\n" +
                "You:\n" +
                "   Hello Lilly I would like to accept this quest.\n" +
                "Lilly:\n" +
                "   Certainly you can accept this quest.\n" +
                "   Here are the details for the location.\n" +
                "You:\n" +
                "   Thank you I will leave right now.\n" +
                "Lilly:\n" +
                "   Good luck on you adventure.\n" +
                "After you finished at the adventurer guild you decided to move towards the farm.\n" +
                "It took you half a hour to reach the farm.\n" +
                "You saw lot's of wheat fields and a few sheds.\n" +
                "When you arrive you got greeted by a nice older man.\n" +
                "You:\n" +
               $"   Greetings I am {_save.Name} I came from the adeventurers guild.\n" +
                "   Do you know where I could find the person who requested this?\n" +
                "Older man:\n" +
                "   Yes that would have been me thank you young men for accepting it.\n" +
                "   My name is Wikker.\n" +
                "You:\n" +
                "   Nice to meet you wikker where can I start?\n" +
                "Wikker:\n" +
                "   Have you ever worked on a farm before?\n" +
                "You:\n" +
                "   No I haven't\n" +
                "Wikker:\n" +
                "   Hmm that's fine it's actually very simple.\n" +
                "   You can get a scythe at the shed over there.\n" +
                "He points towards a shed a few meter away from where you two are talking.\n" +
                "   Harvesting wheat can be done by just cutting it down but please make sure you do it close to the ground.\n" +
                "   Any questions?\n" +
                "You:\n" +
                "   Nope everything is clear.\n" +
                "   I will go the shed now and start working.\n" +
                "Wikker:\n" +
                "   Good luck young man.\n" +
                "You went to the shed and took a scythe from there.\n" +
                "After that you walked to wheat fields to start working.\n" +
                "At the end of the day you talked to wikker again.\n" +
                "You:\n" +
                "   Thank you for this wondefull experience.\n" +
                "   This work was a lot tougher then I expected to be honest.\n" +
                "Wikker:\n" +
                "   Hahaha yup it's hard work but also honest work.\n" +
                "   Thank you for your help hope to see you around again.\n" +
                "You:\n" +
                "   No problem and thank you for the hospitality.\n" +
                "After a day of work you returned to adventurers guild.\n\n" +
                "Press enter to continue.");
            FinishDay();
        }

        // Option 2 of the story to work on a construction site
        public void ConstructionQuest()
        {
            Console.WriteLine("You took the farm quest from the board and went back to the reception desk.\n" +
                "You:\n" +
                "   Hello Lilly I would like to accept this quest.\n" +
                "Lilly:\n" +
                "   Certainly you can accept this quest.\n" +
                "   Here are the details for the location.\n" +
                "You:\n" +
                "   Thank you I will leave right now.\n" +
                "Lilly:\n" +
                "   Good luck on you adventure.\n" +
                "After a short walk you arrive at the building site.\n" +
                "You ask a worker there who the overviewer is and where to find him.\n" +
                "Worker:\n" +
                "   You can find him there now stop bothering me.\n" +
                "You:\n" +
                "   Thank you.\n" +
                "After a bit you arrive at the overviewers place.\n" +
                "You:\n" +
                "   Good day I heard you are the overviewer of the construction site.\n" +
                "Overviewer:\n" +
                "   Yup that's me my name is bob.\n" +
                "   Are you from the adventurers guild?\n" +
                "You:\n" +
               $"   Yes I am also nice to meet you bob I am {_save.Name}.\n" +
                "Bob:\n" +
                "   Awesome we can always use people here.\n" +
                "   For today you can help there to paint the wall ask Paul over there for more info.\n" +
                "You:\n" +
                "   Okay will start right away then.\n" +
                "You walk towards Paul so you can start working.\n" +
                "You:\n" +
                "   Are you Paul?\n" +
                "Paul:\n" +
                "   Yes I am did Bob send you?\n" +
                "You:\n" +
                "   Yes he did I am here to help painting today and he sended me to you.\n" +
                "Paul:\n" +
                "   Ah okay you can start there here is a brush and a can of paint.\n" +
                "You:\n" +
                "   Thank you I will start right away.\n" +
                "After that you enjoy a nice day of work doing a lot of painting.\n" +
                "At the end of the day you talk to paul.\n" +
                "You:\n" +
                "   Was nice working with you.\n" +
                "Paul:\n" +
                "   Agree hopefully the chance will rise again.\n" +
                "   You did a good job with it.\n" +
                "You:\n" +
                "   Thank till we meet again.\n" +
                "Paul:\n" +
                "   Indeed till we meet again\n" +
                "After that you return to the adenturers guild.\n\n" +
                "Press enter to continue.");
            FinishDay();
        }

        // The story part to get the reward and finish the day
        private void FinishDay()
        {
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Some time later you come back from a day of work.\n" +
                "You walk towards the reception desk to find Lilly.\n" +
                "You:\n" +
                "   Hey Lilly I am back can I claim my reward please?\n" +
                "Lilly:\n" +
                "   You certainly can we already confirmed that you finished your quest.\n" +
                "   Here is your reward 10 Coins and 5 points.\n" +
                "You:\n" +
                "   Thank you have a good night.\n" +
                "Lilly:\n" +
                "   You to.\n" +
                "After claiming you reward you decided to go back home.\n\n" +
                "Guide spirit:\n" +
                "   That was all for now hope you enjoyed the first few parts.\n" +
                "   You game progres will now be saved.\n" +
                "   Press enter after that to go back to the main menu.\n");

            _save.Location = "Done";
            _save.Coins = 10;
            _save.Points = 5;
            _dbContext.Update(_save);
            _dbContext.SaveChanges();
            Console.ReadLine();
        }
    }
}
