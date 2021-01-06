using System.Collections.Generic;
using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int Level = 0;
            Console.WriteLine("Hi Friend. Welcome to the Guessing Game.");
            Console.WriteLine("In this game,there are three levels: ");
            Console.WriteLine("1 signifies the Easy Level");
            Console.WriteLine("2 signifies the Intermediate Level");
            Console.WriteLine("3 signifies the Hard Level");
            Console.WriteLine("Friend, kindly signify below which level you would like to play with either 1,2 or 3 ");
            Level = int.Parse(Console.ReadLine());
            Console.WriteLine("You are playing Level" + Level);

            int level1 = 1;
            int level2 = 2;
            int level3 = 3;

            if(Level == level1)
            {
                Console.WriteLine("You have 6 trials");
                Console.WriteLine("Kindly guess a number from 1 to 10" );

                for(int i = 0; i < 6; i++)
                {
                    int input = 0;
                    int randomNumber = new Random().Next(1,10);
                    Console.Write("Take a guess");
                    input = int.Parse(Console.ReadLine());

                    if (input != randomNumber)
                    {
                        Console.WriteLine("Kindly Try Again");
                    }
                    else if (input == randomNumber)
                    {
                        Console.WriteLine("Yay! You Win");
                        break;
                    }
                }

                
            }

        
            if(Level == level2)
            {
                Console.WriteLine("You have 4 trials");
                Console.WriteLine("Kindly guess a number from 1 to 20" );

                for(int i = 0; i < 4; i++)
                    {
                        int input = 0;
                        int randomNumber = new Random().Next(1,20);
                        Console.Write("Take a guess");
                        input = int.Parse(Console.ReadLine());

                        if (input != randomNumber)
                        {
                            Console.WriteLine("Kindly Try Again");
                        }
                        else if (input == randomNumber)
                        {
                            Console.WriteLine("Yay! You Win");
                            break;
                        }
                }
            }

            
            if(Level == level3)
            {
                Console.WriteLine("You have 6 trials");
                Console.WriteLine("Kindly guess a number from 1 to 50" );

                for(int i = 0; i < 6; i++)
                    {
                        int input = 0;
                        int randomNumber = new Random().Next(1,50);
                        Console.Write("Take a guess");
                        input = int.Parse(Console.ReadLine());

                        if (input != randomNumber)
                        {
                            Console.WriteLine("Kindly Try Again");
                        }
                        else if (input == randomNumber)
                        {
                            Console.WriteLine("Yay! You Win");
                            break;
                        }
                }
            }
            
            


                
        }
    }
}
