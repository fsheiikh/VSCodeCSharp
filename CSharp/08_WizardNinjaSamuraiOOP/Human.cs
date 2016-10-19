using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Human
    {
        public string name { get; set; }
        public int health { get; set; }

        //These properties are all protected
        protected int strength { get; set; }
        protected int intelligence { get; set; }
        protected int dexterity { get; set; }

        public static int SamuraiCount {get; set;}

        public Human(string person)
        {
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }

        public Human(string person, int str, int intel, int dex, int hp)
        {
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }

        public void attack(object obj)
        {
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health -= strength * 5;
            }
        }
    }
}