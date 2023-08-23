using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {
            //Stat concepts (most likely aren't final)
            int mana = 70;
            string playerName = "Tom";
            bool attackIsDodged = true;
            float dodgeChance = 12.0f;
            string className = "Mage";

            //Stop mashing on wakeup (Print out advise)
            Console.WriteLine("Just Block LMAO");
            Console.WriteLine("Git Good");

            //Get player input for first and last name
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            playerName = firstName + lastName;

            //Welocome to the real world
            Console.WriteLine("Welcome" +" "+ playerName);
            Console.WriteLine("To a world of mortgages and late fees");
            
            

        }
    }
}
