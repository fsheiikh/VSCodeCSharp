using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
   public class Samurai : Human
   {    
       public Samurai(string name) : base(name)
       {    
           health = 200;
           Human.SamuraiCount++;
       }


       public void deathBlow(object someone)
       {
           Human enemy = someone as Human;
           //Human enemy = (Human)someone; <-- Same type cast as line above
           if(enemy == null) System.Console.WriteLine("enemy doesnt exist");
           else if(enemy.health < 50) enemy.health = 0;

       }

       public void meditate()
       {
           health = 200;
       }

       public void howMany()
       {
           System.Console.WriteLine(Human.SamuraiCount);
       }





   }
}