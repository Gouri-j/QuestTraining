using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20
{
    enum Option
    {
        Stone = 1,
        Paper = 2,
        Scissors = 3
    }
    class Game
    {
        public Option player1 { get; set; }
        public Option player2 { get; set; }        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
           
            int i = 0;
            int j = 0;

            while (i < 10 && j < 10)
            {
                Console.WriteLine("Enter the input: 1.Stone,2.Paper,3.Scissors");
                var playerInput = Console.ReadLine();
                var player1 = (playerInput == "1" ? Option.Stone : playerInput == "2" ? Option.Paper : Option.Scissors);
                game.player1 = player1;
                Console.WriteLine($"{player1}");

                var random = new Random();
                var player2 = random.Next(1, 4);
                game.player2 = (Option)player2;
                Console.WriteLine($"{(Option)player2}");


                if (game.player1 == game.player2)
                {
                    Console.WriteLine("Tie");
                }
                else if (player1 == Option.Scissors && (Option)player2 == Option.Paper ||
                        player1 == Option.Paper && (Option)player2 == Option.Stone ||
                        player1 == Option.Stone && (Option)player2 == Option.Scissors)
                {
                    int markOfPlayer1 = i++;
                    Console.WriteLine($"You scored {i}");
                }
                else
                {
                    int markOfPlayer2 = j++;
                    Console.WriteLine($"Computer scored{j}");
                }
            }

            if (i > j)
            {
                Console.WriteLine("You win");
            }
            else
            {
                Console.WriteLine("Computer win");
            }
        }
    }
}
