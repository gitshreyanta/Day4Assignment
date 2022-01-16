using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndladder
{
    class SnakeLadder2Players
    {
        const int No_Play = 1;
        const int Ladder = 2;
        const int Snake = 3;

        public void Game()
        {
            int count1 = 0;
            int count2 = 0;
            Random random = new Random();
            int counter = 0;



            while (count1 <= 100)
            {
                int dice = random.Next(1, 7);
                int options = random.Next(1, 4);
                bool flag1 = false;
                bool flag2 = false; 
                //Console.WriteLine("dice: {0} Options1: {1}", dice, options);
                counter++;
                if (count1 < 0)
                {
                    count1 = 0;
                }

                int prev_opt = options;

                if (prev_opt == 2 && options == 2)
                {

                }
                switch (options)
                {
                    case No_Play:
                        count = count + 0;
                        //Console.WriteLine("Player is not there");
                        break;

                    case Ladder:
                        count = count + dice;
                        break;
                    //Console.WriteLine("Player Climes");

                    case Snake:
                        count = count - dice;
                        //Console.WriteLine("Player Dies");
                        break;

                    default:
                        //Console.WriteLine("wrong values");
                        break;
                }

                if (count > 100)
                {
                    count = count - dice;
                }
                else if (count == 100)
                    break;

                //Console.WriteLine(count);
            }
            Console.WriteLine("Current Count status: " + count);
            Console.WriteLine("Number of times Dice Rolled: " + counter);


        }
    }
}
