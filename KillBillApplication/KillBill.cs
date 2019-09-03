using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KillBillLibrary;

namespace KillBillApplication
{
    class KillBill
    {
        static void Main(string[] args)
        {

            Console.Title = "Kill Bill: Death List 5";

            //1. Create player (custom class)
            Weapon getWeapon = GetRandom.GetWeaponPlayer();
            Player bride = new Player("Beatrix Kiddo", 80, 50, 5, 10, getWeapon);

            //Print descirption of player
            Console.WriteLine(bride.Name);

            //2. Create loop for room
            bool exit = false; // counter

            do
            {
                //3. Write a method for getting a room description, make random
                Console.WriteLine("\nFight Venue: "+ GetRandom.GetRoom());

                //TODO 4. create opponent info, randomly select one, if player beats three opponents advance to the ulitmate battle against BIll
                // create an instance of every oppponent and put them into method and store them in an array to randomly select one
                Opponent opponent = GetRandom.GetOpponent();
                Console.WriteLine("\nBeatrix vs. {0}", opponent.OpponentName);
                

                //5. creating loop for the menu
                bool reload = false; //counter
                do
                {
                    //6. Menu of decisions on what to do next in the game
                    #region Menu
                    Console.WriteLine("\nPlease choose an action:\nA) Attack\nB) Block\nR) Run Away\nP) Player Info\nO) Opponenet Info\nX) Exit");

                    //7. Catch user input
                    ConsoleKey userChoice = Console.ReadKey(true).Key; //captures on character and we don't want the value printed to screen

                    //8. Clear.Console after we get input
                    Console.Clear();

                    //9. build out switch for user choice
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            // TODO 10 handle dong battle
                            Combat.DoBattle(bride, opponent);
                            if (opponent.Life <= 0)
                            {
                                //its dead
                                reload = true;
                            }
                            // TODO 11 handle if the player wins
                            break;
                        case ConsoleKey.B:
                            //TODO 12 opponent and player gets another attack
                            
                            break;
                        case ConsoleKey.R:
                            //TODO 13 Oppenent gets another attack
                            Console.WriteLine("Retreat!");
                            Console.WriteLine($"{opponent.Name} attacks you, as you retreat.");
                            Combat.DoAttack(opponent, bride);
                            reload = true;
                            //TODO 14 handle running away and getting new room
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine(bride);
                            break;
                        case ConsoleKey.O:
                            //TODO 16 need to write opponent info to screen
                            Console.WriteLine(opponent);
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.WriteLine("You have no courage. Get out of my sight.");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Not a valid option. Try again.");
                            break;
                    }
                    #endregion

                    //TODO 17 check the players life
                    if (bride.Life <= 0)
                    {
                        Console.WriteLine("You died!"); // player wont die
                        exit = true;
                    }

                } while (!reload && !exit);

            } while (!exit); // while exit is NOT true, keep looping
        } // end main
    }
}
