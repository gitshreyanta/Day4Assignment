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

        public void main()
        {
            int counter1 = 0;
            int counter2 = 0;
            bool flag1 = true;
            bool flag2 = false;

            while (counter1 < 100 || counter2 < 100)
            //while(i<10)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                int options = random.Next(1, 4);
                int prev_opt = options;
                //Console.WriteLine("Options"+options);
                //Console.WriteLine("Dice:" + dice);
                if (counter1 < 0)
                { 
                    counter1 = 0;
                }
                if (counter2 < 0)
                { 
                    counter2 = 0;
                }

                if (flag1)
                {
                    int count1=Game(options, dice);
                    counter1 = counter1 + count1 ;
                    flag1 = false;
                    flag2 = true;
                    //Console.WriteLine("Counter1: "+counter1);
                    
                }
                else if (flag2)
                {
                    int count2=Game(options, dice) ;
                    flag2 = false;
                    flag1 = true;
                    counter2 = counter2 + count2;
                    //Console.WriteLine("Counter2: " + counter2);
                }

                if (counter1 > 100 )
                {
                    Console.WriteLine("PLayer 1 is winner: Score "+counter1);
                    break;
                }
                else if (counter2 > 100)
                {
                    Console.WriteLine("Player 2 is Winner: Score "+counter2);
                    break;
                }
            }
            
        }


        public int  Game(int options, int dice)
        {
            int count = 0;
            //int counter = 0;
                //Console.WriteLine("dice: {0} Options1: {1}", dice, options);
               // counter++;
                
                switch (options)
                {
                    case No_Play:
                        count = 0;
                        //Console.WriteLine("Player is not there");
                        break;

                    case Ladder:
                        count = dice;
                        break;
                    //Console.WriteLine("Player Climes");

                    case Snake:
                        count =  - dice;
                        //Console.WriteLine("Player Dies");
                        break;

                    default:
                        //Console.WriteLine("wrong values");
                        break;
                }
            //Console.WriteLine("Count:" + count);
            return count; 


        }
    }
}
