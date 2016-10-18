
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {   
        
        public static void Main(string[] args)
        {   
            Random random = new Random();

            System.Console.WriteLine("__________Random Array__________");
            Console.WriteLine("Sum: " + randomArray());

             System.Console.WriteLine("\n\n__________Coin Flip__________");
             System.Console.WriteLine(tossCoin(random));
             System.Console.WriteLine("Ratio of Heads to Total Tosses: " + tossMultipleCoins(8));

             System.Console.WriteLine("\n\n__________Names__________");
             string[] shuffledNamesLongerThan5 = names();
             foreach (var name in shuffledNamesLongerThan5) System.Console.Write(name + ", ");

             System.Console.WriteLine("\n\n\n");
        }

        
        //creates random array of ints and prints min, max using Linq, and returns sum
        public static int randomArray()
        {   
            Random random = new Random();

            int[] randomInts = new int[10];
            for (int i = 0; i < 10; i++) randomInts[i] = random.Next(5, 25);

            List<int> randomList = randomInts.ToList();
            System.Console.WriteLine("Min: " + randomList.Min()  + "\nMax: " + randomList.Max());
            return randomList.Sum();
        }

        //tosses coin and uses random to determine if heads or tails
        public static string tossCoin(Random random)
        {   

            string coinFace = (random.Next(2) % 2 == 0) ? "Heads" : "Tails";
            
            System.Console.WriteLine("Tossing a Coin");
            System.Console.WriteLine(coinFace);
            return coinFace;
        }

        //tosses coin multiple time sbe calling tosscoin function and return ratio of (head: total tosses)
        public static double tossMultipleCoins(int num)
        {   
            int heads = 0;
            int total = 0;
            Random random = new Random();

            for (int i = 1; i <= num; i++)
            {   
                if(tossCoin(random) == "Heads") heads ++;
                total++;
            }

            System.Console.WriteLine("\n\nHeads: " + heads + "\nTotal: " + total);
            return (double)heads/(double)total;

        }


        //has hard coded array, shuffles it, and returns an array with the names longer than 5
        public static string[] names()
        {
            string[] namesNew = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            string[] shuffledNames = shuffle(namesNew);

            foreach (var name in shuffledNames) System.Console.Write(name + ", ");

            string[] longerThan5 = checkForLength(shuffledNames);

            Console.WriteLine("\n\nShuffled Names longer than 5 Characters: ");
            return longerThan5;
        }


        //fisher yates shuffle
        public static string[] shuffle(string[] names)
        {
            Random random = new Random();
            for (int i = names.Length-1; i > 1; i--)
            {
                int pos = random.Next(i);
                var x = names[i - 1];
                names[i - 1] = names[pos];
                names[pos] = x;
            }

            return names;
        }


        //takes in array and returns an array that has only the values that were longer than 5 characters
        public static string[] checkForLength(string[] names)
        {
            List<string> namesLongerThanFive = new List<string> ();

            for (int i = 0; i < names.Length; i++)
                 if(names[i].Length > 5) namesLongerThanFive.Add(names[i]);

            return namesLongerThanFive.ToArray();
        }
    }
}
