

namespace GameBookTheGreatMountainHike
{
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
            ArchModel Hero = new ArchModel();
            string charClass = "";

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
                        break;
                    case "h":
                        Hero = new HunterModel();
                        charClass = "Hunter";
                        break;
                    case "m":
                        Hero = new Mountaineer();
                        charClass = "Mountaineer";
                        break;
                    case "a":
                        Hero = new AdventurousExplorer();
                        charClass = "Adventurous  Explorer";
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
                        break;
                    case 2:
                        Hero = new HunterModel();
                        charClass = "Hunter";
                        break;
                    case 3:
                        Hero = new Mountaineer();
                        charClass = "Mountaineer";
                        break;
                    case 4:
                        Hero = new AdventurousExplorer();
                        charClass = "Adventourous Explorer";
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

            
        }
    }
}
