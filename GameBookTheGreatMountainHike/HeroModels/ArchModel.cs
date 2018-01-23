using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBookTheGreatMountainHike.HeroModels
{
    public class ArchModel
    {
        Dictionary<string, int> heroStats = new Dictionary<string, int>();
        public ArchModel()
        {
            
            heroStats.Add("health", 10);
            heroStats.Add("wisdom", 8);
            heroStats.Add("strength", 7);
        }

        public void GetHeroStats() 
        {
            foreach (KeyValuePair<string, int> kvp in heroStats)
            {
                
                Console.WriteLine("Feature = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }

        public int RollDice()
        {
            Random rollOne = new Random();
            int rollOneOutcome = rollOne.Next(1, 6);

            Random rollTwo = new Random();
            int rollTwoOutcome = rollTwo.Next(1, 6);

            int finalDiceRollOutcome = rollOneOutcome + rollTwoOutcome;

            return finalDiceRollOutcome;
        }
        
    }
}
