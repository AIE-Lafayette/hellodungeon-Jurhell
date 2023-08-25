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
            //Initializing stats
            float playerHealth = 100;
            float mana = 20;
            float damage = 0;
            float daggerDamage = 5f;
            float swordDamage = 10f;
            float greatswordDamage = 20f;

            //Get player input for name
            Console.WriteLine("Enter your name young traveller");
            string playerName = Console.ReadLine();
            Console.Clear();

            //Beginning of the game wall of text
            Console.WriteLine("Welcome" + " " + playerName);
            Console.WriteLine("Ever since you were a wee lad you've heard stories of adventurers and travellers who fight mythical creatures and gained");
            Console.WriteLine("notoriety for their many accomplishments.");
            Console.WriteLine("You dreamed of one day becoming one of them and having your name immortalized.");
            Console.WriteLine("Now that you have graduated high school you feel as today is day that you take the first step towards your dream.");
            Console.WriteLine("Press any key to continue.");
            Console.Write(">");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("You leave home and begin travelling towards the nearest adventures guild.");
            Console.WriteLine("Upon entering you walk towards the front and are greeted by a young lady.");
            Console.WriteLine("You tell her you are eager to become an adventurer and get out there fight some monsters.");
            Console.WriteLine("She smiles and leaves for a moment but soon returns and lays out three starter weapons for you to use on your journey.");
            Console.ReadKey(true);

            //First player choice
            Console.WriteLine("In front of you lies three blades of varying sizes.");
            Console.WriteLine("On the left is a small daggger that is low in damage but high in swing speed.");
            Console.WriteLine("In the middle is your standard sword, it does more damage but is slower to swing.");
            Console.WriteLine("And on the right is a massive greatsword that deals the most damage but due to it's extreame weight it is really slow to swing.");
            Console.WriteLine("Make your selection");
            Console.WriteLine("1. Dagger");
            Console.WriteLine("2. Sword");
            Console.WriteLine("3. Greatsword");

            string playerChoice = Console.ReadLine();

            //If statements for player choice
            if (playerChoice == "1" || playerChoice == "Dagger");
            {
                Console.WriteLine("You have chosen The Dagger of Maxwell the Swift.");
                Console.WriteLine("A warrior known for his quick reflexes and reactions.");
                Console.WriteLine("You have 5 attack damage.");

                damage = daggerDamage;
            }

            else if (playerChoice == "2" || playerChoice == "Sword")
            {
                Console.WriteLine("You have chosen The Sword of Max The Average.");
                Console.WriteLine("A warrior known for never being bad at anything, but never excelling at anything either.");
                Console.WriteLine("You have 10 attack damage.");

                damage = swordDamage;
            }

            else if (playerChoice == "3" || playerChoice == "Greatsword")
            {
                Console.WriteLine("You have chosen The Greatsword of Maximillian The Strong.");
                Console.WriteLine("A warrior known for his immense strenth and large weaponry.");
                Console.WriteLine("After attempting to lift it and struggling for a while. You think to yourself 'How was that lady able to lift this?");
                Console.WriteLine("You have 20 attack damage");

                damage = greatswordDamage;
            }

            //Stop mashing on wakeup (Print out advise)
            Console.WriteLine("Just Block LMAO");
            Console.WriteLine("Git Good");

            //Stat concepts (most likely aren't final)
            bool attackIsDodged = true;
            float dodgeChance = 12.0f;
            string className = "Mage";

        }
    }
}
