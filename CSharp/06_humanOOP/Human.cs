using System;

namespace ConsoleApplication
{
    public class Human
    {
        public string name {get; set;}
        public int strength = 3;
        public int intelligence = 3;
        public int dexterity = 3;
        public int health = 100;

        public Human(string newName)
        {
            name = newName;
        }

        public Human(string newName, int newStrength, int newIntelligance, int newDexterity, int newHealth)
        {
            name = newName;
            strength = newStrength;
            intelligence = newIntelligance;
            dexterity = newDexterity;
            health = newHealth;
        } 

        public void attack(Human human)
        {
           human.health -= (strength*5); 
        }

    }
}