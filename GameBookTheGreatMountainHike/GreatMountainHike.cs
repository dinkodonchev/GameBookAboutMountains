

namespace GameBookTheGreatMountainHike
{
    using GameBookTheGreatMountainHike.Constants.Pages;
    using GameBookTheGreatMountainHike.HeroModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GreatMountainHike
    {
        static void Main(string[] args)
        {

            //MAIN PROBLEM - HOW THE F*CK AM I GONNA ACHIEVE TO BRANCH OUT AFTER EVERY CHOICE WITHOUT MAKING A BIG MESS OF SPAGHETTI CODE???

            //ToDo NB! - Try and use as many OOP concepts and good practices as possible in this project. 
            //DesignPAterns igf needed. Interfaces if needed. Enums if needed. 
            //Complex DataStructures like Dictionaries etc if needed. And so on... Good luck!

            // The actual cool text and game logic for the book you can create along the way or at the very end ;)

            ArchModel Hero = new ArchModel();
            //Set up some variables we will need along the way
            string charClass = "";
            int pageNumber = 0;
            
            

            Console.WriteLine("Would you like to choose your hero class or do you leave it at the hands of Faith?");
            Console.WriteLine();
            Console.WriteLine("To choose - press Y. To leave it at random - press N.");
            Console.WriteLine();
            ConsoleKeyInfo BirthChoice = Console.ReadKey();
            Console.WriteLine();

            if (BirthChoice.Key == ConsoleKey.Y)
            {
                Console.WriteLine("For Shepherd, press S! For Hunter, press H. For Mountaineer, press M. For Adventurous Explorer, press A. Type a correspondig letter to pick a class:");
                Console.WriteLine();
                string choice = Console.ReadLine();


                switch (choice.ToLower())
                {
                    case "s":
                        Hero = new ShepherdModel();
                        charClass = "Shepherd";
                        pageNumber = 2;
                        break;
                    case "h":
                        Hero = new HunterModel();
                        charClass = "Hunter";
                        pageNumber = 3;
                        break;
                    case "m":
                        Hero = new Mountaineer();
                        charClass = "Mountaineer";
                        pageNumber = 4;
                        break;
                    case "a":
                        Hero = new AdventurousExplorer();
                        charClass = "Adventurous  Explorer";
                        pageNumber = 5;
                        break;
                    default:
                        Hero = new Mountaineer();
                        break;
                }
            }

            else if (BirthChoice.Key == ConsoleKey.N)
            {
                
                Random randHeroClass = new Random();
                int OrisiyaFaith = randHeroClass.Next(1, 4);

                switch (OrisiyaFaith)
                {
                    case 1:
                        Hero = new ShepherdModel();
                        charClass = "Shepherd";
                        pageNumber = 2;

                        break;
                    case 2:
                        Hero = new HunterModel();
                        charClass = "Hunter";
                        pageNumber = 3;
                        
                        break;
                    case 3:
                        Hero = new Mountaineer();
                        charClass = "Mountaineer";
                        pageNumber = 4;
                        
                        break;
                    case 4:
                        Hero = new AdventurousExplorer();
                        charClass = "Adventourous Explorer";
                        pageNumber = 5;
                        
                        break;
                    default:
                        Hero = new Mountaineer();
                        break;
                }
            }
            var indefiniteArticle = charClass == "Adventourous Explorer" ? "an" : "a";
            Console.WriteLine("Congrats! You have been born {0} {1}.", indefiniteArticle, charClass);
            Console.WriteLine();
            var heroType = Hero.GetType();
            Console.WriteLine(heroType);
            //Declaring the type of character and his initial adventure, according to it
            Page page = new Page(pageNumber);
            page.WritePageContent();
            //More Tests - ToDo - To think of an actual question which goes with the story. The story should slowly start to unfold and come together.
            Console.WriteLine("What do you choose? A, B, C or D?");
            Console.WriteLine();
            ConsoleKeyInfo ABCD_Choice = Console.ReadKey();
            Console.WriteLine();
            //There has got to be a smarter way? Iterations? Probably not, since every page and every choice is too custom...
            if (ABCD_Choice.Key == ConsoleKey.A) 
            {
                page = new Page(7);
                page.WritePageContent();
            }
            
           

            // Here goes beginning of story according to your hero class

            // Must implement logic to always have these a) b) c) d) choices and load different pages;

            //Test PAge WritePageContent method
            

        }
    }
}
