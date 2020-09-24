using System;

namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int myrandomnumber = rnd.Next(1, 11);
            Console.WriteLine("what is my random number?");
            int userguess = Int32.Parse(Console.ReadLine());
            bool correctguess = false;

            while (!correctguess)
            {
             if (userguess == myrandomnumber)
                {
                    Console.WriteLine("U won!!");
                    correctguess = true;
                }
                else
                {
                    Console.WriteLine("what is my number?");
                    userguess = Int32.Parse(Console.ReadLine());


                }

                
            }
        }
    }
}
