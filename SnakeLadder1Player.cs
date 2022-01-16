using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndladder
{
    public class SnakeLadder
    {
        const int No_Play = 1;
        const int Ladder = 2;
        const int Snake = 3;

        public void Game()
        {
            int count1 = 0;
            Random random = new Random();
            int counter = 0;

            while (count1 <= 100 )
                {
                int dice = random.Next(1, 7);
                int options = random.Next(1, 4);
               
                    //Console.WriteLine("dice: {0} Options1: {1}", dice, options);
                counter++;
                if (count1 < 0)
                {
                    count1 = 0;
                }

                switch (options)
                    {
                        case No_Play:
                            count1 = count1 + 0;
                            //Console.WriteLine("Player is not there");
                            break;

                        case Ladder:
                            count1 = count1 + dice;
                            break;
                        //Console.WriteLine("Player Climes");

                        case Snake:
                            count1 = count1 - dice;
                            //Console.WriteLine("Player Dies");
                            break;

                        default:
                            //Console.WriteLine("wrong values");
                            break;
                    }

                    if (count1 > 100)
                    {
                        count1 = count1 - dice;
                    }
                    else if (count1 == 100)
                        break;

                    //Console.WriteLine(count);
            }
                Console.WriteLine("Current Count status: " + count1);
                Console.WriteLine("Number of times Dice Rolled: " + counter);
        }   
    }
}
