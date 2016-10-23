using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Enemy : Human
    {   
        public Enemy(string name) : base(name)
        {
            strength = 4;
            intelligence = 2;
            dexterity = 2;
            health = 110;

        }

        public void eat(List<Human> heros, Random random)
        {
            Human hero = heros.ElementAt(random.Next(heros.Count()));
            attack(hero);
        }
    }

    public class Zombie : Enemy
    {
        public Zombie(string name) : base(name)
        {

        }

        
    }

    public class Spider : Enemy
    {
        public Spider(string name) : base(name)
        {
            strength = 1;
        }
    }


}