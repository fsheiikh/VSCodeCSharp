using System.IO;
using Microsoft.AspNetCore.Hosting;
using System;



namespace HelloNancy
{
    public class Gold
    {   
       public static int totalGold {get; set;}
       public static int tempGold {get; set;}
       public static string allGold {get; set;}

       public static int getTotalGold()
       {
            totalGold = (totalGold == 0) ? 0 : totalGold;
            return totalGold;
       }

       public static int checkBuilding(string name)
       {
           if(name == "farm")  tempGold = new System.Random().Next(10,20);
           else if(name == "cave") tempGold = new System.Random().Next(5,10);
           else if(name == "house") tempGold = new System.Random().Next(2,5);
           else if (name == "casino") tempGold = new System.Random().Next(-50,50);
           else tempGold = 0;
           
           totalGold += tempGold;
           return tempGold;
       }

       public static string setGolds(int golds)
       {    
           string tempMessage = (golds >= 0) ? "<span class='green'>earned " : "<span class='red'>lost";

           allGold += tempMessage + golds.ToString() + " at " + DateTime.Now + "</span><br><br>";
           return allGold;

       }

       public static void reset()
       {
           totalGold = 0;
           tempGold = 0;
           allGold = " ";
       }



        
    }
}