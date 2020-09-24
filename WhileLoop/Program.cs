using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int myrandomnumber =rnd.Next(1, 11);
            Console.WriteLine("What is my number from 1 to 10:");
            int userguess = Int32.Parse(Console.ReadLine());

            if (myrandomnumber == userguess)
            {
                Console.WriteLine("Congratulation! you have played me.");
            }
            else
            { 
            Console.WriteLine($"wrong. my random number is {myrandomnumber}");


            }



            

        }
    }
}
