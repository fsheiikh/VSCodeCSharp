using System.IO;
using Microsoft.AspNetCore.Hosting;
using System;



namespace HelloNancy
{
    public class Random
    {   
        public static int RandNum {get; set;}

       public static void setToZero()
       {
           RandNum = 0;
       }

        public static int getRandom() 
        {   
            if(RandNum == 0)
            {   
                RandNum = new System.Random().Next(1,101);
                return RandNum;
            }
            else 
                return RandNum;
        }

        public static string checkGuess(string guess)
        {   
            if(Int32.Parse(guess) == RandNum)
            {
                RandNum = 0;
                return "You got it, the number was " + guess;
            }
            else if (Int32.Parse(guess) > RandNum){
                return "Too High";
            }
            else if (Int32.Parse(guess) < RandNum){
                return "Too Low";
            }
            else 
                return "Not a number";


        }
    }
}