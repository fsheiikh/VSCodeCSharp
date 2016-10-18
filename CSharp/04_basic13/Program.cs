
using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            System.Console.WriteLine("Print 1-255");
            for (int i = 1; i < 256; i++) System.Console.Write(i + ",") ;
            
            System.Console.WriteLine("\n\n Print odd numbers between 1-255");
            for (int i = 1; i < 256; i+=2) System.Console.Write(i + ",") ;

            System.Console.WriteLine("\n\n Print Sum (Using List/Linq syntax)");
            System.Console.WriteLine(Enumerable.Range(0, 255).Sum());

            System.Console.WriteLine("\n\n Iterating through an Array");
            int[] myArray = {1, 3, 5, 7, 9, 13};
            foreach (int number in myArray) System.Console.Write(number + ",");
            

            System.Console.WriteLine("\n\nFind Max, Average, Array with Odd Numbers, Greater than Y, Square the Values, Eliminate Negative Numbers, Shifting the values in an array: \n");
            int[] numbers = {1, 3, -4, 7, 6};
            arraySolve(numbers, 1);
            shiftValue(numbers);
            System.Console.WriteLine("\n\n");

            
        }

        public static void arraySolve(int[] array, int Y = 0)
        {   
            List<int> myArray = array.ToList();
            Console.WriteLine("Max: " + myArray.Max());
            Console.WriteLine("Average: " + myArray.Average());

            int[] oddArray = myArray.Where(n => n % 2 !=0 ).ToArray();
            System.Console.Write("Array with Odd Numbers: ");
            foreach (var number in oddArray) Console.Write(number + ",");
            
            int greaterThanY = myArray.Where(n => n > Y).Count();
            System.Console.WriteLine("\nGreater Than Y: " + greaterThanY);

            var valuesSquared = myArray.Select(n => n * n);
            System.Console.Write("Square the Values: " );
            foreach (var val in valuesSquared) Console.Write(val + ",");

            var noNegatives = myArray.Where(n => n > 0);
            System.Console.Write("\nEliminate Negative Numbers: ");
            foreach (var num in noNegatives ) Console.Write(num + ",");

            //Eliminate Negatives w/o List
            List<int> newArr = new List<int>();
            foreach(int number in array)
            {
                if(number % 2 > 0) newArr.Add(number);
                else newArr.Add(0);
            }
            int[] newerArr = newArr.ToArray();
        }

        public static void shiftValue(int[] array)
        {   
             int temp = array[array.Length-1];

            for (int i = array.Length-1; i > 0 ; i--) array[i] = array[i-1];

            array[0] = temp;

            System.Console.Write("\nShift Values: ");
            foreach(var number in array) Console.Write(number + ",");
        }

        // public static void numberToString(object[] array)
        // {
        //     for (int i = 0; i < array.Length; i++) arr[i] = (arr[i] is string) ? "Dojo" : arr[i];
        //     System.Console.WriteLine("Number To String: ");
        //     foreach (var item in array) System.Console.Write(item + ", ");


        // }

    }
}
