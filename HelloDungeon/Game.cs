using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        void Ints(int a, int b)
        {
            for(int i = a; i<=b; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }

        string DisplayMenu(string prompt, string option1, string option2, string option3)
        {
            string playerChoice = "";
            while (playerChoice != "1" && playerChoice != "2" && playerChoice != "3")
            {
                //Display prompt
                Console.Clear();
                Console.WriteLine(prompt);

                //Display all options
                Console.WriteLine("1." + option1); 
                Console.WriteLine("2." + option2);
                Console.WriteLine("3." + option3);
               
                //Get player input
                Console.WriteLine("> ");
                playerChoice = Console.ReadLine();

                //If the player input is not one of the available options...
                if (playerChoice != "1" && playerChoice != "2" && playerChoice != "3")
                {
                    //...display the error message
                    Console.Clear();
                    Console.WriteLine("Sorry I don't speak illiterate.");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey(true);
                }
            }

            return playerChoice;
        }

        public void Run()
        {
           
            
            Ints(1,100);
            
            return;

            //Initializing stats
            string playerName = "Tom";
            string playerChoice = "";
            float playerHealth = 100;
            float mana = 20;
            float damage = 1f;
            float daggerDamage = 5f;
            float swordDamage = 10f;
            float greatswordDamage = 20f;
            bool playerAlive = true;
            bool enemyAlive = true;

            //Get player input for name
            while (playerChoice != "1")
            {
                Console.WriteLine("Enter your name young traveller");
                Console.Write("> ");
                playerName = Console.ReadLine();

                Console.WriteLine(playerName + " Is that correct?");
               
                //Player name confirmation
                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");
                Console.WriteLine(">");
                playerChoice = Console.ReadLine();

                if (playerChoice == "1" || playerChoice == "Yes")
                {
                    playerChoice = "1";
                }
                else if (playerChoice == "2" || playerChoice == "No")
                {
                    Console.Clear();
                    Console.WriteLine("My Apologies");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("I'm sorry I don't speak illiterate");
                    Console.ReadKey(true);
                    Console.Clear();
                }
            }
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
            Console.WriteLine("Upon entering you walk towards the front desk and are greeted by a young lady.");
            Console.WriteLine("You tell her how eager you are to become an adventurer and get out there fight some monsters.");
            Console.WriteLine("She smiles and hands you a guild registration form to fill out");
            Console.WriteLine("While you're doing that she leaves for a moment but later returns and lays out three starter weapons for you to use on your journey.");
            Console.ReadKey(true);
            Console.Clear();
            
            //Initializing bool for weapon choice loop
            bool weaponSelected = false;

            //First player choice
            while (weaponSelected == false)
            {
                Console.WriteLine("\"In front of you lies three blades in varying sizes from The Brothers Max.");
                Console.WriteLine("On the left is a small daggger that is low in damage but high in swing speed.");
                Console.WriteLine("In the middle is your standard sword, it does more damage but is slower to swing.");
                Console.WriteLine("And on the right is a massive greatsword that deals the most damage but also has the slowest swing speed.\"");
                Console.WriteLine("Make your selection");
                Console.WriteLine("1. Dagger");
                Console.WriteLine("2. Sword");
                Console.WriteLine("3. Greatsword");

                playerChoice = Console.ReadLine();

                //If statements for player choice
                if (playerChoice == "1" || playerChoice == "Dagger")
                {
                    Console.Clear();
                    Console.WriteLine("You have chosen The Dagger of Maxwell the Swift.");
                    Console.WriteLine("A warrior known for his quick reflexes and reactions.");
                    Console.WriteLine("You have 5 attack damage.");

                    Console.WriteLine("\"Great choice. You look like the speedy type.");

                    damage = daggerDamage;
                    weaponSelected = true;
                }

                else if (playerChoice == "2" || playerChoice == "Sword")
                {
                    Console.Clear();
                    Console.WriteLine("You have chosen The Sword of Max The Average.");
                    Console.WriteLine("A warrior known for never being bad at anything, but never excelling at anything either.");
                    Console.WriteLine("You have 10 attack damage.");

                    Console.WriteLine("\"Great choice. You can go wrong with ole reliable");

                    damage = swordDamage;
                    weaponSelected = true;
                }

                else if (playerChoice == "3" || playerChoice == "Greatsword")
                {
                    Console.Clear();
                    Console.WriteLine("You have chosen The Greatsword of Maximillian The Strong.");
                    Console.WriteLine("A warrior known for his immense strenth and large weaponry.");
                    Console.WriteLine("After attempting to lift it and struggling for a while. You think to yourself \"How was that lady able to lift this?\"");
                    Console.WriteLine("You have 20 attack damage");

                    Console.WriteLine("\"Not the choice I would've gone with (especially since you could barely lift the thing).");
                    Console.WriteLine("But if that's what you want.");

                    damage = greatswordDamage;
                    weaponSelected = true;
                }

                else
                {
                    Console.WriteLine("I'm sorry. What the hell did you just say?");
                    Console.WriteLine("Press any key to try again");
                    Console.ReadKey(true);
                    Console.Clear();

                }
            }
            
            //After selection has been made
            Console.WriteLine("Now follow me " + playerName + " let's go meet the other newbies.\"");
            Console.ReadKey(true);
            Console.Clear();

            //Introducing team options
            Console.WriteLine("\"Here are some of the other new recruits.");
            Console.WriteLine("You're in luck these three are in need of a fourth member to form a proper party.");
            Console.WriteLine("Try talking to them and getting to know each other before heading out on you first quest\"");

            //Display stats function
            void PrintStats(string a, float b)
            {
                Console.WriteLine("Name: " + a);
                Console.WriteLine("Damage: " + b);
            }
            
            PrintStats(playerName, damage);

            //Eventual battle loop
            while (playerAlive == true && enemyAlive == true)
            {
                //Battle
            }
            
            //Stop mashing on wakeup (Print out advise)
            Console.WriteLine("Just Block LMAO");
            Console.WriteLine("Git Good");

            //End of game while loop
            while (playerChoice != "1");
        }
    }
}
