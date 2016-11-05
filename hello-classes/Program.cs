using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pizza myPizza = new Pizza("large", "new york");
            myPizza.AddTopping("cheese");
            myPizza.AddTopping("jalapenos");
            myPizza.AddTopping("tandoori chicken");
            myPizza.AddTopping("spanish chorizo");
            Console.WriteLine("Your pizza will cost: " + myPizza.Cost);
        }
    }
}
