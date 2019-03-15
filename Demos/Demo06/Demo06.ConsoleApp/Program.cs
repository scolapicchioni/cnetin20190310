using System;

namespace Demo06.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IDice dice = new Dice();
            IPlayer m = new Player(dice) { Name = "Mario" };
            IPlayer l = new Player(dice) { Name = "Luigi" };

            Game g = new Game(m, l);

            IPlayer winner = g.Play();
            Console.WriteLine($"{m.Name} rolled a {m.LastRoll}");
            Console.WriteLine($"{l.Name} rolled a {l.LastRoll}");

            if (winner == null)
            {
                Console.WriteLine("TIE");
            }
            else {
                Console.WriteLine($"{winner.Name} won");
            }
            Console.ReadLine();

        }
    }
}
