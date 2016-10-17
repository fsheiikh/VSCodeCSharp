using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            System.Console.WriteLine("Print 1-255");
            for (int i = 1; i < 256; i++)
                Console.WriteLine(i);

            System.Console.WriteLine("Print 1-100 % by 3 or 5 but not both");
            for (int i = 1; i < 101; i++)
                if((i%3 == 0 || i%5 == 0) && !(i%3 == 0 && i%5 == 0)) System.Console.WriteLine(i);

            System.Console.WriteLine("Print 1-100 print Fizz if %3, Buzz if %5, or FizzBuzz if both");
            for (int i = 1; i < 101; i++)
            {
                if(i%3 == 0 && i%5 == 0) System.Console.WriteLine("FizzBuzz");    
                else if(i%3==0) System.Console.WriteLine("Fizz");
                else if(i%5==0) System.Console.WriteLine("Buzz");   
                else System.Console.WriteLine(i); 
            }
        }
    }
}
