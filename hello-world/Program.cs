using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(100000);
            if (randomNumber < 33333)
            {
                Console.WriteLine("You look marvelous, Aaron.");
            }
            else if(randomNumber > 66666)
            {
                Console.WriteLine("You look marvelous, Michelle.");
            }
            else
            {
                Console.WriteLine("More pizza, now.");
                Console.WriteLine("Get me some more coffee, too");
            }
        }
    }
}
