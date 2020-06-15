    using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Kim");
            Human human2 = new Human("Jae",2,2,2,100);
            human1.Attack(human2);
            human2.Attack(human1);

        }
    }

    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
         
        // add a public "getter" property to access health
        public int healthProp
        {
            get { return health;}
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string SomeName){
            Name = SomeName;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        // Add a constructor to assign custom values to all fields
        public Human(string someName, int power, int intel, int dex, int hel)
        {
            Name = someName;
            Strength = power;
            Intelligence = intel;
            Dexterity = dex;
            health = hel;
        }
        // Build Attack method
        public int Attack(Human target)
        {
            target.health -= (5*this.Strength);

            Console.WriteLine(Strength);
            Console.WriteLine(target.health);
            return target.health;
        }
    }

}
