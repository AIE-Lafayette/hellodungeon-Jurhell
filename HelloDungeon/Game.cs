using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        //Initializing stats
        string playerName = "Tom";
        string playerChoice = "";
        float playerHealth = 20;
        float enemyHealth = 25;
        float damage = 1f;
        float daggerDamage = 5f;
        float swordDamage = 10f;
        float greatswordDamage = 20f;
        float archerDamage = 10f;
        float mageDamage = 15f;
        float enemyDamage = 2f;
        int currentScene = 0; 
        bool playerAlive = true;
        bool enemyAlive = true;

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

        //Player choice function
        string PlayerChoose(string prompt, string option1, string option2, string option3)
        {
            playerChoice = "";
            while (playerChoice != "1" && playerChoice != "2" && playerChoice != "3")
            {
                //Display prompt
                Console.Clear();
                Console.WriteLine(prompt);

                //Display all options
                Console.WriteLine("1." + option1); 
                Console.WriteLine("2." + option2);
                
                if (option3 != "")
                {
                    Console.WriteLine("3." + option3);
                }
               
                //Get player input
                Console.WriteLine("> ");
                playerChoice = Console.ReadLine();

                //If the player input is not one of the available options...
                if (playerChoice != "1" && playerChoice != "2")
                {
                    if(playerChoice == "3" && option3 != "")
                    {
                        continue;
                    }

                    //...display the error message
                    Console.Clear();
                    Console.WriteLine("Sorry I don't speak illiterate.");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey(true);

                    playerChoice = "";
                }
            }

            return playerChoice;
        }

        string FalseChoice(string prompt, string option1, string option2, string option3)
        {
            playerChoice = "";
            while (playerChoice != "1")
            {
                //Display prompt
                Console.Clear();
                Console.WriteLine(prompt);

                //Display all options
                Console.WriteLine("1." + option1);
                Console.WriteLine("2." + option2);
                Console.WriteLine("2." + option3);

                //Get player input
                Console.WriteLine("> ");
                playerChoice = Console.ReadLine();

                //If the player input is not one of the available options...
                if (playerChoice != "1" && playerChoice != "2" && playerChoice != "3")
                {
                    

                    //...display the error message
                    Console.Clear();
                    Console.WriteLine("You try saying something but suddenly lose the ability to speak. " +
                       "You just end up looking like an idiot.");
                    Console.ReadKey(true);
                    Console.Clear();

                    
                }
            }
            return playerChoice;
        }

        //Display stats function
        void PrintStats(string a, float b)
        {
            Console.WriteLine("Name: " + a);
            Console.WriteLine("Damage: " + b);
        }

        //Display party stats fuction
        void PrintPartyStats(string nPlayer, float dPlayer, float dEva, float dHerald)
        {
            Console.WriteLine(nPlayer);
            Console.WriteLine("Damage " + dPlayer);
            Console.WriteLine("Eva");
            Console.WriteLine("Damage " + dEva);
            Console.WriteLine("Herald Archibald of The High Order XVII");
            Console.WriteLine("Damage " + dHerald);
        }

        //Main menu function
        void DisplayMainMenu()
        {
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
                currentScene = 1;
            }
        }

        void DisplayScene1()
        {
            //Beginning of the game wall of text
            Console.Clear();
            Console.WriteLine("Welcome" + " " + playerName);
            Console.WriteLine("You are a young idealistic individual on your way to becoming an adventurer. " +
                "Ever since you were a child you dreamed of one day going on journeys and having your name immortalized.");
            Console.WriteLine("Press any key to continue.");
            Console.Write(">");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("You leave home and begin travelling towards the nearest adventures guild. " +
                "Upon entering you walk towards the front desk and are greeted by a young lady. " +
                "You tell her how eager you are to become an adventurer and get out there fight some monsters. " +
                "She smiles and hands you a guild registration form to fill out " +
                "While you're doing that she leaves for a moment but later returns and lays out three starter weapons for you to use on your journey.");
            Console.Write(">");
            Console.ReadKey(true);
            Console.Clear();

            //First player choice
            PlayerChoose("\"In front of you lies three blades in varying sizes from The Brothers Max.\" Make your selection.", "Dagger", "Sword", "Greatsword");

            //If statements for player choice
            if (playerChoice == "1" || playerChoice == "Dagger")
            {
                playerChoice = "1";
                Console.Clear();

                Console.WriteLine("You have chosen The Dagger of Maxwell the Swift.");
                Console.WriteLine("A warrior known for his quick reflexes and reactions.");

                damage = daggerDamage;

                PrintStats(playerName, damage);
                Console.Write(">");
                Console.ReadKey(true);

                Console.WriteLine("\"Great choice. Not too much weight and handy in a fight.");
                Console.Write(">");
            }

            else if (playerChoice == "2" || playerChoice == "Sword")
            {
                playerChoice = "2";
                Console.Clear();

                Console.WriteLine("You have chosen The Sword of Max The Average.");
                Console.WriteLine("A warrior known for never being bad at anything, but never excelling at anything either.");

                damage = swordDamage;

                PrintStats(playerName, damage);
                Console.Write(">");
                Console.ReadKey(true);

                Console.WriteLine("\"Great choice. You can't go wrong with ole reliable");
                Console.Write(">");
            }

            else if (playerChoice == "3" || playerChoice == "Greatsword")
            {
                playerChoice = "3";
                Console.Clear();

                Console.WriteLine("You have chosen The Greatsword of Maximillian The Strong.");
                Console.WriteLine("A warrior known for his immense strenth and large weaponry.");
                Console.WriteLine("After attempting to lift it and struggling for a while. You think to yourself \"How was that lady able to lift this?\"");

                damage = greatswordDamage;

                PrintStats(playerName, damage);
                Console.Write(">");
                Console.ReadKey(true);

                Console.WriteLine("\"Not the choice I would've gone with (especially since you could barely lift the thing).");
                Console.WriteLine("But if that's what you want.");
                Console.Write(">");
            }

            else
            {
                Console.WriteLine("I'm sorry. What the hell did you just say?");
                Console.WriteLine("Press any key to try again");
                Console.ReadKey(true);
                Console.Clear();

            }

            //After selection has been made
            Console.Clear();
            Console.WriteLine("Now follow me " + playerName);
            Console.WriteLine("Here are some fellow new recruits. " +
                "You're in luck these three are in need of a third member to form a proper party. " +
                "Try talking to them and getting to know each other before heading out on you first quest\"");
            Console.Write(">");
            Console.ReadKey(true);
            Console.Clear();

            currentScene = 2;
        }

        void DisplayScene2()
        {
            //Player meets teammates
            Console.WriteLine("In the room with you are two other novices. One is a young lad archer named Herald Archibald of The High Order XVII. " +
                "And the other is a young lady mage named Eva. " +
                "You make your introductions and become acquainted with each other before planning to head out on your first adventure. " +
                "The three of you make your way towards the community board to see if any quests are available.");
            Console.WriteLine(" ");

            PrintPartyStats(playerName, damage, mageDamage, archerDamage);

            Console.Write(">");
            Console.ReadKey(true);
            Console.Clear();

            //Player chooses quest

            //FalseChoice("Looking at the board there appear to be three quests available. Which one will you accept?", "Slay five slime", "Clear an infestation of giant spiders from the town nut farm", "Slay the ancient dragon \"Fafnir the destroyer of worlds and devourer of souls\"");

                //if (playerChoice == "1")
                //{
                //    Console.Clear();
                //    Console.WriteLine("Your party chooses to accept the accept the quest of slaying five slimes. " +
                //        "Written on the board it says that a group of slime are hanging around the nearby fields and scaring away potiental tourists. " +
                //        "The town's main source of income is tourism so this is an urgent matter. " +
                //        "The town is willing to give whatever group completes this quest a small reward. " +
                //        "It isn't much but your party has to start somewhere.");
                //}
                //else if (playerChoice == "2")
                //{
                //    Console.Clear();
                //    Console.WriteLine("You suggest clearing the spider infestation but your party disagrees. " +
                //        "Herald Archibald of The High Order XVII says no because he has a peanut allergy and doesn't want to be anywhere near the farm " +
                //        "(Even though he's an archer and doesn't need to be close to the peanuts to kill the spiders). " +
                //        "And Eva doesn't want to accept the quest because she has servere arachnophobia. " +
                //        "Looks like this one is off the table.");
                //}
                //else if (playerChoice == "3")
                //{
                //    Console.WriteLine("You stare at the quest description for a while then look towards the rest of your party. " +
                //        "Before you can even get any words out you notice that they're both staring at you with looks of disapproval. " +
                //        "Both of them saying \"You can't be serious\" with just their facial expressions. " +
                //        "You begin looking at the other available quests.");
                //}
                //else
                //{
                //    Console.WriteLine("You try saying but suddenly lose the ability to speak. " +
                //        "You just end up looking like an idiot.");
                //    Console.ReadKey(true);
                //    Console.Clear();
                //}
            currentScene = 3;
        }

        void DisplayScene3()
        {
            //Text before slime encounter
            Console.Clear();
            Console.WriteLine("You all look at the board and find a low level quest where you must slay five slimes in the fields outside of town.");
            Console.WriteLine("The three of you of head off towards the fields at the other end of town. " +
                "Upon arriving you see the group of slimes hanging around along the main path that leads into town. " +
                "Herald Archibald of The High Order XVII begins redirecting the flow of incomming tourists to a safer path away from the slimes. " +
                "Eva uses a basics luring spell to attract the slimes towards her. " +
                "While you just stand around and look pretty. " +
                "Once all the slimes are near the three of you group up and prepare for your battle");
            Console.Write(">");
            Console.ReadKey(true);
            Console.Clear();
            currentScene = 4;
        }

        void DisplayEnd()
        {
            //End of game 
            Console.Clear();
            Console.WriteLine("Herald Archibald of The High Order XVII draws his bow, Eva use a spell for trapping all the slimes within the area to prevent any from escaping." +
                "And you unsheath your blade and prepare to swing when suddenly one of the slimes attacks your arm knocking your weapon out of your hand.");
            Console.Write(">");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("You end up losing your balance and falling onto Eva whose staff ends up hitting Herald Archibald of The High Order XVII in the face. " +
                "The staff had some residual mana on it which knocks him out. " +
                "Eva is obviously upset and begins to scold you forgetting about the slimes in that moment. " +
                "One of the more intelligent slimes grabs your weapon with its gel like body and jumps at her with the blade piercing her back.");
            Console.Write(">");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("You end up freaking out and try to flee but run in the barrier put up by Eva. " +
                "Realizing you're trapped as long as it's up you take her staff and repeatedly hit the barrier with it. " +
                "Eva sees this and with her last breath she calls you an idiot. " +
                "Meanwhile the slimes continue to make their way towards Herald Archibald of The High Order XVII. " +
                "Eventually you someone bring down the barrier and leave your party members for dead. " +
                "The Slimes consuming their bodies.");
            Console.Write(">");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("The whole ordeal made you realize that maybe being an adventurer isn't for you. " +
                "So you begin heading back home. " +
                "Thinking maybe you'd be better off getting an office job instead. " +
                "And hey at least you got a cool mage staff as souvenir.");
            Console.Write(">");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("Congradulations. You've made it to the end of the game.");
                Console.WriteLine("Thank you for reading.");
                Console.ReadKey(true);
                PlayerChoose("Would you like to read again?", "Yes", "No", "");
        }

        public void Run()
        {

            while (playerHealth >= 0)
            {
                if (currentScene == 0)
                {
                    DisplayMainMenu();
                }
                else if (currentScene == 1)
                {
                    DisplayScene1();
                }
                else if (currentScene == 2)
                {
                    DisplayScene2();
                }
                else if (currentScene == 3)
                {
                    DisplayScene3();
                }
                else if (currentScene == 4)
                {
                    //End of game
                    DisplayEnd();
                   
                }

            }
        }
    }
}
