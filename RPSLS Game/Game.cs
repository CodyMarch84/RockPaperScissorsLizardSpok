using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Game
{
    class Game
    {
        //member variables
        HumanPlayer player1;
        Player player2;
        Choice i = new Choice();

        public Game()
        {
            DisplayRules();
            player1 = new HumanPlayer();
            GameOptions();
        }

        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("Two players each choose an option of Rock, Paper, Scissors, Lizard or Spock.");
            Console.WriteLine("The winner is decided by which choice is better.");
            Console.WriteLine("Rules are as follows below:");
            Console.WriteLine("Rock beats Scissors and Lizard \nPaper beats Rock and Spock \nScissors beats Paper and Lizard \nLizard beats Paper and Spock \nSpock beats Rock and Scissors");
            Console.WriteLine("If there is a tie, the round is repeated until there is a winner.");
            Console.WriteLine("Best two out of three rounds wins the game!");
        }

        public void GameOptions()
        {
            Console.WriteLine("Game Options: ");
            Console.WriteLine("Enter 1 for Player vs Computer.");
            Console.WriteLine("Enter 2 for Player vs Player.");
            string playerTypes = Console.ReadLine();

            switch (playerTypes)
            {
                case "1":
                    Console.WriteLine("Option 1 was entered");
                    player2 = new ComputerPlayer();
                    Rounds();
                    break;
                case "2":
                    Console.WriteLine("Option 2 was entered");
                    player2 = new HumanPlayer();
                    Rounds();
                    break;
                default:
                    Console.WriteLine("Entry invalid, enter either 1 or 2.\n");
                    GameOptions();
                    break;
            }
        }

        public void CompareChoices()
        {
            int player1choice = player1.UserInput();
            int player2choice = player2.UserInput();

            if(player1choice == player2choice)
            {
                Console.WriteLine("You tied! Try again!");
            }
            else if(player1choice == 0)
            {
                if(player2choice == 2 || player2choice == 3)
                {
                    Console.WriteLine(player1.name + " wins!");
                    Console.WriteLine(player2.name + " chose " + i.choices[player2choice]);
                    player1.score++;
                }
                else
                {
                    Console.WriteLine(player2.name + " wins!");
                    Console.WriteLine(player2.name + " chose " + i.choices[player2choice]);
                    player2.score++;
                }
            }
            else if(player1choice == 1)
            {
                if(player2choice == 0 || player2choice == 4)
                {
                    Console.WriteLine(player1.name + " wins!");
                    Console.WriteLine(player2.name + " chose " + i.choices[player2choice]);
                    player1.score++;
                }
                else
                {
                    Console.WriteLine(player2.name + " wins!");
                    Console.WriteLine(player2.name + " chose " + i.choices[player2choice]);
                    player2.score++;
                }
            }
            else if(player1choice == 2)
            {
                if(player2choice == 1 || player2choice == 3)
                {
                    Console.WriteLine(player1.name + " wins!");
                    Console.WriteLine(player2.name + " chose " + i.choices[player2choice]);
                    player1.score++;
                }
                else
                {
                    Console.WriteLine(player2.name + " wins!");
                    Console.WriteLine(player2.name + " chose " + i.choices[player2choice]);
                    player2.score++;
                }
            }
            else if(player1choice == 3)
            {
                if(player2choice == 1 || player2choice == 4)
                {
                    Console.WriteLine(player1.name + " wins!");
                    Console.WriteLine(player2.name + " chose " + i.choices[player2choice]);
                    player1.score++;
                }
                else
                {
                    Console.WriteLine(player2.name + " wins!");
                    Console.WriteLine(player2.name + " chose " + i.choices[player2choice]);
                    player2.score++;
                }
            }
            else if(player1choice == 4)
            {
                if(player2choice == 0 || player2choice == 2)
                {
                    Console.WriteLine(player1.name + " wins!");
                    Console.WriteLine(player2.name + " chose " + i.choices[player2choice]);
                    player1.score++;
                }
                else
                {
                    Console.WriteLine(player2.name + " wins!");
                    Console.WriteLine(player2.name + " chose " + i.choices[player2choice]);
                    player2.score++;
                }
            }
        }

        public void Rounds()
        {
            while (player1.score < 2 && player2.score < 2)
            {
                CompareChoices();
            }
            if(player1.score == 2)
            {
                Console.WriteLine(player1.name + " Wins the game!");
            }
            else
            {
                Console.WriteLine(player2.name + " Wins the game!");
            }
        }
    }
}
