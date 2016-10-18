using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("1). Three Basic Arrays ________");

            //Create an empty array to hold integer values 0 through 9
            int[] threeValues = new int[10];
            for (int i = 0; i < 10; i++) threeValues[i] = i;
            foreach (var number in threeValues) System.Console.WriteLine(number);
            System.Console.WriteLine("\n");

            //Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            var names = new string[4] {"Tim", "Martin", "Nikki", "Sara"};
            foreach(var name in names) System.Console.WriteLine(name);
            System.Console.WriteLine("\n");

            //Create an array with space 10 that alternates between true and false values, starting with true
            bool[] spaces = new bool[10];
            for(int i = 0; i<10; i++) spaces[i] = (i%2==0) ? true : false;
            foreach (var item in spaces) System.Console.WriteLine(item);
            System.Console.WriteLine("\n");


            System.Console.WriteLine("2). Multiplication Table ________");
            int[,] table = new int[10, 10];
           
           //generate tablewith doubel for loop
           for (int i = 0; i < 10; i++)
               for (int j = 0; j < 10; j++)
                   table[i, j] = j+i+1 + (j*i);

            //print array elements out to screen
           for (int j = 0; j < 10; j++)
           {
               string line = "";
                for (int i = 0; i < 10; i++)
                    line += table[j, i].ToString() + ",";

                Console.WriteLine(line);
           }

           
           //Multiplication table without array
            //for(var i = 1; i < 11; i++) 
                //for(var j = 1; j < 11; j++) 
                    //Console.WriteLine(i*j);
            System.Console.WriteLine("\n");
                
            System.Console.WriteLine("3). User Info Dictionary________");
            
            //Create a Dictionary for storing Name, Favorite Sport, Num of Pets, and True/False for whether or not a user like Ice Cream.
           //Create 2 different dictionaries holding information for the 4 people in the array you created earlier (Tim, Martin, Nikki, Sara).
           Dictionary<string, string> Tim = new Dictionary<string, string> ();
           
                Tim.Add("Name", "Tim");
                Tim.Add("Favorite Sport", "Basketball");
                Tim.Add("Number of Pets", "3");
                Tim.Add("Likes Ice Cream", "false");

            Dictionary<string, string> Martin = new Dictionary<string, string> ();
           
                Martin.Add("Name", "Martin");
                Martin.Add("Favorite Sport", "Football");
                Martin.Add("Number of Pets", "4");
                Martin.Add("Likes Ice Cream", "True");

       

        List<Dictionary<string, string>> people = new  List<Dictionary<string, string>> ();

        people.Add(Martin);
        people.Add(Tim);

        foreach(var person in people)
        {
            System.Console.WriteLine("{0} likes {1}, has {2} pets", person["Name"], person["Favorite Sport"], person["Number of Pets"]);

        }
        }
    }
}
