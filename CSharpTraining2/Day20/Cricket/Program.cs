using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    class Player
    {
        public string Name { get; set; }
        public int Runs { get; set; }
        public int BallsFaced { get; set; }
        public bool Isout { get; set; }

        public Player(string name)
        {
            Name = name;
            Runs = 0;
            BallsFaced = 0;
            Isout = false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the player name");
            string name = Console.ReadLine();
            var player = new Player(name);

            while(player.Isout == false)
            {
                Console.WriteLine("Enter the runs");
                int runs = int.Parse(Console.ReadLine());

                if (runs <= 6)
                {
                    var random = new Random();
                    var computer = random.Next(0, 7);
                    Console.WriteLine($"{computer}");

                    if (computer == runs)
                    {
                        Console.WriteLine("You are out");
                        Console.WriteLine($"Your score : {player.Runs}");
                        Console.WriteLine($"Number of balls faced : {player.BallsFaced}");
                        player.BallsFaced++;
                        player.Isout = true;
                    } 
                    else if (computer == 0)
                    {
                        Console.WriteLine("No ball");
                        player.Runs += runs + 1;
                        Console.WriteLine($"Score: {player.Runs}");

                    }
                    else
                    {
                        player.Runs += runs;
                        Console.WriteLine($"Score: {player.Runs}");
                        Console.WriteLine($"Ball faced : {player.BallsFaced}");
                        player.BallsFaced++; 
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}
