using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Wizard : Human
    {
        public Wizard(String name) : base(name)
        {
            intelligence = 25;
            health = 50;
        }

        public void heal()
        {
            health += (intelligence*10);
        }

        public void fireball(object someone)
        {   
            Random random = new Random();
            Human enemy = someone as Human;
            enemy.health -= random.Next(20, 50);

        }
    }
}