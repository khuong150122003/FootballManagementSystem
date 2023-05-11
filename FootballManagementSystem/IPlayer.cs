using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagementSystem
{
    internal class IPlayer : Object
    {

        public string Name;
        public int Age;
        public int attack;
        public int defense;
        public int stamina;
        public int speed;
        public int power;

        public IPlayer(string name, int age, int attack, int defense, int stamina, int speed, int power)
        {
            Name = name;
            Age = age;
            this.attack = attack;
            this.defense = defense;
            this.stamina = stamina;
            this.speed = speed;
            this.power = power;
        }


        public string name { get { return Name; } set { Name = value; } }
        public string age { get { return age; } set { age = value; } }
        public int Attack { get { return attack; } set { attack = value; } }

        public int Defense { get { return defense; } set { defense = value; } }

        public int Stamina { get { return stamina; } set { stamina = value; } }

        public int Speed { get { return speed; } set { speed = value; } }

        public int Power { get { return power; } set { power = value; } }

        public IPlayer() { }
        public void GetInfo()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Attack: {0}", Attack);
            Console.WriteLine("Defense: {0}", Defense);
            Console.WriteLine("Stamina: {0}", Stamina);
            Console.WriteLine("Speed: {0}", Speed);
            Console.WriteLine("Power: {0}", Power);
        }

    }
}

