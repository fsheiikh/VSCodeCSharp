
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<object> stuff = new List<object>();

            stuff.Add("This is a string");
            stuff.Add(0);
            stuff.Add(true);

            foreach (var item in stuff)
            {
                if(item is string) Console.WriteLine("A string");
                else if(item is int) Console.WriteLine("A Number");
                else if(item is bool) Console.WriteLine("A Boolean");
            }

            //To print out individually, we need to cast
        }
    }
}
