using System;

namespace ThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 11);
            int userinput; 
            int counter = 0;
            Console.WriteLine(randomnumber);

            while (counter < 3)
            {
                Console.WriteLine("what is my number?");
                userinput = Int32.Parse(Console.ReadLine());
                if (randomnumber == userinput)
                {
                    Console.WriteLine("Congrats. u won.");
                    break;
                }
                else if (counter > 3)
                {
                    Console.WriteLine("u run out of tries.");
                }
                else
                {
                    Console.WriteLine("try again");
                    counter = counter + 1;
                    Console.WriteLine($"u have guessed {counter} times.");                                        
                }

                

            }
            
        }
    }
}
