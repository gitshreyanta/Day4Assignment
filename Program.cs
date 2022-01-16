using System;

namespace SnakeAndladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snakes & Ladders Games");
            SnakeLadder snakeLadder = new SnakeLadder();
            snakeLadder.Game();
           
            
        }
    }
}
