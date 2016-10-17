using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");

            Cat cat = new Cat();

            Console.WriteLine(cat.cat);

            // loop from 1 to 5 including 5
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            // loop from 1 to 5 excluding 5
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
