using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApplication
{
    public class Ninja : Human
    {
        public Ninja(String name) : base(name)
        {
            dexterity = 175;
        }

        public void steal(object someone)
        {
            base.attack(someone);
            health += 10;
        } 

        public void getAway()
        {
            health -= 15;
        }



    }
}